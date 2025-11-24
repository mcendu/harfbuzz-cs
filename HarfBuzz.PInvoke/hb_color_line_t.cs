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

namespace HarfBuzz.PInvoke
{
    public unsafe partial struct hb_color_line_t
    {
        public void* data;

        [NativeTypeName("hb_color_line_get_color_stops_func_t")]
        public delegate* unmanaged[Cdecl]<hb_color_line_t*, void*, uint, uint*, hb_color_stop_t*, void*, uint> get_color_stops;

        public void* get_color_stops_user_data;

        [NativeTypeName("hb_color_line_get_extend_func_t")]
        public delegate* unmanaged[Cdecl]<hb_color_line_t*, void*, void*, hb_paint_extend_t> get_extend;

        public void* get_extend_user_data;

        public void* reserved0;

        public void* reserved1;

        public void* reserved2;

        public void* reserved3;

        public void* reserved5;

        public void* reserved6;

        public void* reserved7;

        public void* reserved8;
    }
}
