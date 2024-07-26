using System;
using System.Text;

namespace Nuklear.NET.Examples {
	public static class Shared {
		static NuklearCalculator CalcA;
		static NuklearCalculator CalcB;

		static StringBuilder ConsoleBuffer = new StringBuilder();
		static StringBuilder InputBuffer = new StringBuilder();

		public static void Init(NuklearDevice Dev) {
			NuklearApi.Init(Dev);

			CalcA = new NuklearCalculator("Calc A", 50, 50);
			CalcB = new NuklearCalculator("Calc B", 300, 50);

			for (int i = 0; i < 30; i++)
				ConsoleBuffer.AppendLine("LINE NUMBER " + i);
		}

		public static void DrawLoop(float DeltaTime = 0) {
			NuklearApi.SetDeltaTime(DeltaTime);

			NuklearApi.Frame(() => {
				if (CalcA.Open)
					CalcA.Calculator();

				if (CalcB.Open)
					CalcB.Calculator();

				TestWindow(400, 350);
				ConsoleThing(450, 200, ConsoleBuffer, InputBuffer);
			});
		}


		static void TestWindow(float X, float Y) {
			const NkPanelFlags Flags = NkPanelFlags.Border | NkPanelFlags.Scalable | NkPanelFlags.Movable | NkPanelFlags.Title | NkPanelFlags.Minimizable | NkPanelFlags.ScrollAutoHide;

			NuklearApi.Window("Test Window", X, Y, 200, 200, Flags, () => {
				NuklearApi.LayoutRowDynamic(35);

				for (int i = 0; i < 5; i++)
					if (NuklearApi.ButtonLabel("Some Button " + i))
						Console.WriteLine("You pressed button " + i);

				if (NuklearApi.ButtonLabel("Exit"))
					Environment.Exit(0);
			});
		}

		static void ConsoleThing(int X, int Y, StringBuilder OutBuffer, StringBuilder InBuffer) {
			const NkPanelFlags Flags = NkPanelFlags.Border | NkPanelFlags.Title | NkPanelFlags.Movable| NkPanelFlags.Scalable | NkPanelFlags.Minimizable;

			NuklearApi.Window("Console", X, Y, 300, 300, Flags, () => {
				NkRect Bounds = NuklearApi.WindowGetBounds();
				NuklearApi.LayoutRowDynamic(Bounds.H - 85);
				NuklearApi.EditString(NkEditTypes.Editor | (NkEditTypes)(NkEditFlags.GotoEndOnActivate), OutBuffer);

				NuklearApi.LayoutRowDynamic();
				if ((NuklearApi.EditString(NkEditTypes.Field, InBuffer)?.HasFlag(NkEditEvents.Active) ?? false) && NuklearApi.IsKeyPressed(NkKeys.Enter)) {
					string Txt = InBuffer.ToString().Trim();
					InBuffer.Clear();

					if (Txt.Length > 0)
						OutBuffer.AppendLine(Txt);
				}
			});
		}

		// Throw the calculator in the garbage lmao. It isn't even functional. It's just a demonstration for the GUI anyway ¯\_(ツ)_/¯
		class NuklearCalculator {
			public enum CurrentThing {
				A = 0,
				B
			}

			public bool Open = true;
			public bool Set;
			public float A, B;
			public char Prev, Op;

			public CurrentThing CurrentThingy;
			public float Current {
				get {
					if (CurrentThingy == CurrentThing.A)
						return A;
					return B;
				}
				set {
					if (CurrentThingy == CurrentThing.A)
						A = value;
					else
						B = value;
				}
			}

			StringBuilder Buffer;
			string Name;
			float X, Y;

			public NuklearCalculator(string Name, float X, float Y) {
				Buffer = new StringBuilder(255);

				this.Name = Name;
				this.X = X;
				this.Y = Y;
			}

			public void Calculator() {
				const string Numbers = "789456123";
				const string Ops = "+-*/";
				const NkPanelFlags F = NkPanelFlags.Border | NkPanelFlags.Movable | NkPanelFlags.NoScrollbar | NkPanelFlags.Title
					| NkPanelFlags.Closable | NkPanelFlags.Minimizable;

				bool Solve = false;
				string BufferStr;

				NuklearApi.Window(Name, X, Y, 180, 250, F, () => {
					NuklearApi.LayoutRowDynamic(35, 1);

					Buffer.Clear();
					Buffer.AppendFormat("{0:0.00}", Current);

					NuklearApi.EditString(NkEditTypes.Simple, Buffer, (ref NkTextEdit TextBox, uint Rune) => {
						char C = (char)Rune;

						if (char.IsNumber(C))
							return true;

						return false;
					});

					BufferStr = Buffer.ToString().Trim();
					if (BufferStr.Length > 0)
						if (float.TryParse(BufferStr, out float CurFloat))
							Current = CurFloat;

					NuklearApi.LayoutRowDynamic(35, 4);
					for (int i = 0; i < 16; i++) {
						if (i == 12) {
							if (NuklearApi.ButtonLabel("C")) {
								A = B = 0;
								Op = ' ';
								Set = false;
								CurrentThingy = CurrentThing.A;
							}

							if (NuklearApi.ButtonLabel("0")) {
								Current = Current * 10;
								Op = ' ';
							}

							if (NuklearApi.ButtonLabel("=")) {
								Solve = true;
								Prev = Op;
								Op = ' ';
							}
						} else if (((i + 1) % 4) != 0) {
							int NumIdx = (i / 4) * 3 + i % 4;

							if (NumIdx < Numbers.Length && NuklearApi.ButtonText(Numbers[NumIdx])) {
								Current = Current * 10 + int.Parse(Numbers[NumIdx].ToString());
								Set = false;
							}
						} else if (NuklearApi.ButtonText(Ops[i / 4])) {
							if (!Set) {
								if (CurrentThingy != CurrentThing.B)
									CurrentThingy = CurrentThing.B;
								else {
									Prev = Op;
									Solve = true;
								}
							}

							Op = Ops[i / 4];
							Set = true;
						}
					}

					if (Solve) {
						if (Prev == '+')
							A = A + B;
						else if (Prev == '-')
							A = A - B;
						else if (Prev == '*')
							A = A * B;
						else if (Prev == '/')
							A = A / B;

						CurrentThingy = CurrentThing.A;
						if (Set)
							CurrentThingy = CurrentThing.B;

						B = 0;
						Set = false;
					}
				});

				if (NuklearApi.WindowIsClosed(Name) || NuklearApi.WindowIsHidden(Name))
					Open = false;
			}
		}
	}
}