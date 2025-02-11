// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#pragma once

#include <vector>

enum class IpcCommand : short
{
    Unknown,
    Status,
    Callstack
};

struct IpcMessage
{
    IpcCommand Command = IpcCommand::Unknown;
    std::vector<BYTE> Payload;
};
