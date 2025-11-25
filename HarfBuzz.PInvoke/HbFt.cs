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

using System;
using System.Runtime.InteropServices;

namespace HarfBuzz.PInvoke
{
    public static unsafe partial class HbFt
    {
        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint hb_ft_face_create([NativeTypeName("FT_Face")] nint ft_face, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint hb_ft_face_create_cached([NativeTypeName("FT_Face")] nint ft_face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint hb_ft_face_create_referenced([NativeTypeName("FT_Face")] nint ft_face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint hb_ft_face_create_from_file_or_fail([NativeTypeName("const char *")] byte* file_name, [NativeTypeName("unsigned int")] uint index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint hb_ft_face_create_from_blob_or_fail([NativeTypeName("hb_blob_t*")] nint blob, [NativeTypeName("unsigned int")] uint index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_font_t*")]
        public static extern nint hb_ft_font_create([NativeTypeName("FT_Face")] nint ft_face, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_font_t*")]
        public static extern nint hb_ft_font_create_referenced([NativeTypeName("FT_Face")] nint ft_face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("FT_Face")]
        public static extern nint hb_ft_font_get_ft_face([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("FT_Face")]
        public static extern nint hb_ft_font_lock_face([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void hb_ft_font_unlock_face([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void hb_ft_font_set_load_flags([NativeTypeName("hb_font_t*")] nint font, int load_flags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int hb_ft_font_get_load_flags([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void hb_ft_font_changed([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_ft_hb_font_changed([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void hb_ft_font_set_funcs([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("FT_Face")]
        [Obsolete]
        public static extern nint hb_ft_font_get_face([NativeTypeName("hb_font_t*")] nint font);
    }
}
