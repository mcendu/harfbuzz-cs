HarfBuzz.PInvoke
================
This library consists of automatically generated, low-level P/Invoke
bindings to [HarfBuzz].

If you are looking for high-level, safe bindings, you should check out
other libraries, like [HarfBuzzSharp].

## Installing
To add this library to your project using the .NET CLI:

```console
$ dotnet add package McEndu.HarfBuzz.PInvoke
```

The package does not provide HarfBuzz itself; you are responsible for
shipping the natives.

## Usage
All method bindings in this library are intended to be imported via
`using static`. To do the equivalent of `#include <hb.h>`, for example,
put in the top of your source file:

```csharp
// Write the following line once
using HarfBuzz.PInvoke;
// Write a `using static` line for each equivalent of a C header
using static HarfBuzz.PInvoke.Hb;
```

All functions have the same name as the corresponding C API; refer to
[HarfBuzz documentation][HarfBuzz] for usage. Note that you have to
manually marshal strings to use them with this library.

## Generating
The bindings are generated using [ClangSharpPInvokeGenerator]. Run the
following command in your clone repository to install it:

```console
$ dotnet tool restore
```

`codegen/` in the root of this repository contains prepared arguments
to ClangSharpPInvokeGenerator. To regenerate `Hb.cs` and associated
classes, run in the repo root:

```console
$ dotnet ClangSharpPInvokeGenerator \
    -F/path/to/harfbuzz-headers \
    @codegen/common-unix.args \
    @codegen/hb.args
```

### FAQ: Invalid libClang version
A libclang from your distro might have been used. On Linux, you can use
the `LD_LIBRARY_PATH` environment variable to ensure that the libclang
shipped with ClangSharpPInvokeGenerator is used:

  ```console
  $ LD_LIBRARY_PATH="$HOME/.dotnet/tools/.store/\
  clangsharppinvokegenerator/20.1.2.4/\
  clangsharppinvokegenerator.linux-x64/20.1.2.4/tools/any/linux-x64/" \
  dotnet ClangSharpPInvokeGenerator # ...
  ```

### FAQ: `stddef.h` not found
On Linux, some standard library headers are expected to be supplied
with the compiler, instead of by the C standard library. Unfortunately,
the libclang build that comes with ClangSharpPInvokeGenerator may have
trouble finding them.

On Fedora 43, add one of the following arguments (of course you need
to install a C/C++ compiler):

  - If `clang20-libs` is installed:

  ```
  -I/usr/lib/clang/20/include
  ```

  - Otherwise, if you use clang:

  ```
  -I/usr/lib/clang/20/include
  ```

  - Otherwise, if you use GCC, and you are using normal PC hardware:

  ```
  -I/usr/lib/gcc/x86_64-redhat-linux/15/include
  ```

Other distributions may place compiler headers in different places;
refer to your distro for further instructions.

## License

Copyright © 2025 Du Yijie.
Copyright © 2009 Red Hat, Inc.

Permission is hereby granted, without written agreement and without
license or royalty fees, to use, copy, modify, and distribute this
software and its documentation for any purpose, provided that the
above copyright notice and the following two paragraphs appear in
all copies of this software.

IN NO EVENT SHALL THE COPYRIGHT HOLDER BE LIABLE TO ANY PARTY FOR
DIRECT, INDIRECT, SPECIAL, INCIDENTAL, OR CONSEQUENTIAL DAMAGES
ARISING OUT OF THE USE OF THIS SOFTWARE AND ITS DOCUMENTATION, EVEN
IF THE COPYRIGHT HOLDER HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH
DAMAGE.

THE COPYRIGHT HOLDER SPECIFICALLY DISCLAIMS ANY WARRANTIES, INCLUDING,
BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
FITNESS FOR A PARTICULAR PURPOSE.  THE SOFTWARE PROVIDED HEREUNDER IS
ON AN "AS IS" BASIS, AND THE COPYRIGHT HOLDER HAS NO OBLIGATION TO
PROVIDE MAINTENANCE, SUPPORT, UPDATES, ENHANCEMENTS, OR MODIFICATIONS.

[HarfBuzz]: https://harfbuzz.github.io/
[HarfBuzzSharp]: https://www.nuget.org/packages/HarfBuzzSharp/
[ClangSharpPInvokeGenerator]: https://github.com/dotnet/ClangSharp/
