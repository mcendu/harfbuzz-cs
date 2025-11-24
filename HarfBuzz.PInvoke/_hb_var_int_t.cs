/*
 * Copyright © 2009  Red Hat, Inc.
 *
 * Permission is hereby granted, without written agreement and without
 * license or royalty fees, to use, copy, modify, and distribute this
 * software and its documentation for any purpose, provided that the
 * above copyright notice and the following two paragraphs appear in
 * all copies of this software.
 *
 * IN NO EVENT SHALL THE COPYRIGHT HOLDER BE LIABLE TO ANY PARTY FOR
 * DIRECT, INDIRECT, SPECIAL, INCIDENTAL, OR CONSEQUENTIAL DAMAGES
 * ARISING OUT OF THE USE OF THIS SOFTWARE AND ITS DOCUMENTATION, EVEN
 * IF THE COPYRIGHT HOLDER HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH
 * DAMAGE.
 *
 * THE COPYRIGHT HOLDER SPECIFICALLY DISCLAIMS ANY WARRANTIES, INCLUDING,
 * BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE.  THE SOFTWARE PROVIDED HEREUNDER IS
 * ON AN "AS IS" BASIS, AND THE COPYRIGHT HOLDER HAS NO OBLIGATION TO
 * PROVIDE MAINTENANCE, SUPPORT, UPDATES, ENHANCEMENTS, OR MODIFICATIONS.
 */

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HarfBuzz.PInvoke
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _hb_var_int_t
    {
        [FieldOffset(0)]
        [NativeTypeName("uint32_t")]
        public uint u32;

        [FieldOffset(0)]
        [NativeTypeName("int32_t")]
        public int i32;

        [FieldOffset(0)]
        [NativeTypeName("uint16_t[2]")]
        public _u16_e__FixedBuffer u16;

        [FieldOffset(0)]
        [NativeTypeName("int16_t[2]")]
        public _i16_e__FixedBuffer i16;

        [FieldOffset(0)]
        [NativeTypeName("uint8_t[4]")]
        public _u8_e__FixedBuffer u8;

        [FieldOffset(0)]
        [NativeTypeName("int8_t[4]")]
        public _i8_e__FixedBuffer i8;

        [InlineArray(2)]
        public partial struct _u16_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(2)]
        public partial struct _i16_e__FixedBuffer
        {
            public short e0;
        }

        [InlineArray(4)]
        public partial struct _u8_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(4)]
        public partial struct _i8_e__FixedBuffer
        {
            public sbyte e0;
        }
    }
}
