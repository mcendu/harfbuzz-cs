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
    public static unsafe partial class HbSubset
    {
        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_subset_input_t*")]
        public static extern nint hb_subset_input_create_or_fail();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_subset_input_t*")]
        public static extern nint hb_subset_input_reference([NativeTypeName("hb_subset_input_t*")] nint input);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void hb_subset_input_destroy([NativeTypeName("hb_subset_input_t*")] nint input);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_subset_input_set_user_data([NativeTypeName("hb_subset_input_t*")] nint input, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* hb_subset_input_get_user_data([NativeTypeName("const hb_subset_input_t *")] nint input, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void hb_subset_input_keep_everything([NativeTypeName("hb_subset_input_t*")] nint input);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_set_t*")]
        public static extern nint hb_subset_input_unicode_set([NativeTypeName("hb_subset_input_t*")] nint input);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_set_t*")]
        public static extern nint hb_subset_input_glyph_set([NativeTypeName("hb_subset_input_t*")] nint input);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_set_t*")]
        public static extern nint hb_subset_input_set([NativeTypeName("hb_subset_input_t*")] nint input, hb_subset_sets_t set_type);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_map_t*")]
        public static extern nint hb_subset_input_old_to_new_glyph_mapping([NativeTypeName("hb_subset_input_t*")] nint input);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern hb_subset_flags_t hb_subset_input_get_flags([NativeTypeName("hb_subset_input_t*")] nint input);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void hb_subset_input_set_flags([NativeTypeName("hb_subset_input_t*")] nint input, [NativeTypeName("unsigned int")] uint value);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_subset_input_pin_all_axes_to_default([NativeTypeName("hb_subset_input_t*")] nint input, [NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_subset_input_pin_axis_to_default([NativeTypeName("hb_subset_input_t*")] nint input, [NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint axis_tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_subset_input_pin_axis_location([NativeTypeName("hb_subset_input_t*")] nint input, [NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint axis_tag, float axis_value);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_subset_input_get_axis_range([NativeTypeName("hb_subset_input_t*")] nint input, [NativeTypeName("hb_tag_t")] uint axis_tag, float* axis_min_value, float* axis_max_value, float* axis_def_value);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_subset_input_set_axis_range([NativeTypeName("hb_subset_input_t*")] nint input, [NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint axis_tag, float axis_min_value, float axis_max_value, float axis_def_value);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_subset_axis_range_from_string([NativeTypeName("const char *")] byte* str, int len, float* axis_min_value, float* axis_max_value, float* axis_def_value);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void hb_subset_axis_range_to_string([NativeTypeName("hb_subset_input_t*")] nint input, [NativeTypeName("hb_tag_t")] uint axis_tag, [NativeTypeName("char *")] byte* buf, [NativeTypeName("unsigned int")] uint size);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint hb_subset_preprocess([NativeTypeName("hb_face_t*")] nint source);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint hb_subset_or_fail([NativeTypeName("hb_face_t*")] nint source, [NativeTypeName("const hb_subset_input_t *")] nint input);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint hb_subset_plan_execute_or_fail([NativeTypeName("hb_subset_plan_t*")] nint plan);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_subset_plan_t*")]
        public static extern nint hb_subset_plan_create_or_fail([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("const hb_subset_input_t *")] nint input);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void hb_subset_plan_destroy([NativeTypeName("hb_subset_plan_t*")] nint plan);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_map_t*")]
        public static extern nint hb_subset_plan_old_to_new_glyph_mapping([NativeTypeName("const hb_subset_plan_t *")] nint plan);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_map_t*")]
        public static extern nint hb_subset_plan_new_to_old_glyph_mapping([NativeTypeName("const hb_subset_plan_t *")] nint plan);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_map_t*")]
        public static extern nint hb_subset_plan_unicode_to_old_glyph_mapping([NativeTypeName("const hb_subset_plan_t *")] nint plan);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_subset_plan_t*")]
        public static extern nint hb_subset_plan_reference([NativeTypeName("hb_subset_plan_t*")] nint plan);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int hb_subset_plan_set_user_data([NativeTypeName("hb_subset_plan_t*")] nint plan, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* hb_subset_plan_get_user_data([NativeTypeName("const hb_subset_plan_t *")] nint plan, hb_user_data_key_t* key);
    }
}
