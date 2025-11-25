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

using System.Runtime.InteropServices;

namespace HarfBuzz.PInvoke
{
    public static unsafe partial class HbAat
    {
        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint hb_aat_layout_get_feature_types([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* feature_count, hb_aat_layout_feature_type_t* features);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_ot_name_id_t")]
        public static extern uint hb_aat_layout_feature_type_get_name_id([NativeTypeName("hb_face_t*")] nint face, hb_aat_layout_feature_type_t feature_type);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint hb_aat_layout_feature_type_get_selector_infos([NativeTypeName("hb_face_t*")] nint face, hb_aat_layout_feature_type_t feature_type, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* selector_count, hb_aat_layout_feature_selector_info_t* selectors, [NativeTypeName("unsigned int *")] uint* default_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_aat_layout_has_substitution([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_aat_layout_has_positioning([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_aat_layout_has_tracking([NativeTypeName("hb_face_t*")] nint face);

        [NativeTypeName("#define HB_AAT_LAYOUT_NO_SELECTOR_INDEX 0xFFFFu")]
        public const uint HB_AAT_LAYOUT_NO_SELECTOR_INDEX = 0xFFFFU;
    }
}
