# credit to mr yabloko
cmake_minimum_required(VERSION 3.26)
project(Nuklear)
set(CMAKE_WINDOWS_EXPORT_ALL_SYMBOLS ON)

set("NUGET_ARCH" "x64")
if(${CMAKE_SYSTEM_NAME} STREQUAL "Darwin")
    set("NUGET_ARCH" "")
elseif(${CMAKE_SYSTEM_PROCESSOR} STREQUAL "ARM64")
    set("NUGET_ARCH" "arm64")
elseif(${CMAKE_SYSTEM_PROCESSOR} STREQUAL "x86")
    set("NUGET_ARCH" "x86")
endif()

if(${CMAKE_SYSTEM_NAME} STREQUAL "Windows")
    set("NUGET_PLATFORM" "win")
elseif(${CMAKE_SYSTEM_NAME} STREQUAL "Linux")
    set("NUGET_PLATFORM" "linux")
elseif(${CMAKE_SYSTEM_NAME} STREQUAL "Darwin")
    set("NUGET_PLATFORM" "osx")
endif()

set(FinalPath "${CMAKE_CURRENT_BINARY_DIR}/../runtimes/${NUGET_PLATFORM}-${NUGET_ARCH}/native/")

add_library(Nuklear SHARED nuklear.c)
target_include_directories(Nuklear PUBLIC Nuklear)

add_custom_command(TARGET Nuklear POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E make_directory ${FinalPath}
    COMMAND ${CMAKE_COMMAND} -E copy $<TARGET_FILE:Nuklear> ${FinalPath}
)