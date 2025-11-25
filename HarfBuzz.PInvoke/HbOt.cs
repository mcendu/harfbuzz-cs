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
using static HarfBuzz.PInvoke.hb_ot_math_glyph_part_flags_t;

namespace HarfBuzz.PInvoke
{
    public static unsafe partial class HbOt
    {
        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_name_list_names", ExactSpelling = true)]
        [return: NativeTypeName("const hb_ot_name_entry_t *")]
        public static extern hb_ot_name_entry_t* name_list_names([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int *")] uint* num_entries);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_name_get_utf8", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint name_get_utf8([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_ot_name_id_t")] uint name_id, [NativeTypeName("hb_language_t")] nint language, [NativeTypeName("unsigned int *")] uint* text_size, [NativeTypeName("char *")] byte* text);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_name_get_utf16", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint name_get_utf16([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_ot_name_id_t")] uint name_id, [NativeTypeName("hb_language_t")] nint language, [NativeTypeName("unsigned int *")] uint* text_size, [NativeTypeName("uint16_t *")] ushort* text);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_name_get_utf32", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint name_get_utf32([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_ot_name_id_t")] uint name_id, [NativeTypeName("hb_language_t")] nint language, [NativeTypeName("unsigned int *")] uint* text_size, [NativeTypeName("uint32_t *")] uint* text);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_has_palettes", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int color_has_palettes([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_palette_get_count", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint color_palette_get_count([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_palette_get_name_id", ExactSpelling = true)]
        [return: NativeTypeName("hb_ot_name_id_t")]
        public static extern uint color_palette_get_name_id([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint palette_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_palette_color_get_name_id", ExactSpelling = true)]
        [return: NativeTypeName("hb_ot_name_id_t")]
        public static extern uint color_palette_color_get_name_id([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint color_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_palette_get_flags", ExactSpelling = true)]
        public static extern hb_ot_color_palette_flags_t color_palette_get_flags([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint palette_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_palette_get_colors", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint color_palette_get_colors([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint palette_index, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* color_count, [NativeTypeName("hb_color_t *")] uint* colors);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_has_layers", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int color_has_layers([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_glyph_get_layers", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint color_glyph_get_layers([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* layer_count, hb_ot_color_layer_t* layers);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_has_paint", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int color_has_paint([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_glyph_has_paint", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int color_glyph_has_paint([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_codepoint_t")] uint glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_has_svg", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int color_has_svg([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_glyph_reference_svg", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint color_glyph_reference_svg([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_codepoint_t")] uint glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_has_png", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int color_has_png([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_color_glyph_reference_png", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint color_glyph_reference_png([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_table_choose_script", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        [Obsolete]
        public static extern int layout_table_choose_script([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("const hb_tag_t *")] uint* script_tags, [NativeTypeName("unsigned int *")] uint* script_index, [NativeTypeName("hb_tag_t *")] uint* chosen_script);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_script_find_language", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        [Obsolete]
        public static extern int layout_script_find_language([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_index, [NativeTypeName("hb_tag_t")] uint language_tag, [NativeTypeName("unsigned int *")] uint* language_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_tags_from_script", ExactSpelling = true)]
        [Obsolete]
        public static extern void tags_from_script(hb_script_t script, [NativeTypeName("hb_tag_t *")] uint* script_tag_1, [NativeTypeName("hb_tag_t *")] uint* script_tag_2);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_tag_from_language", ExactSpelling = true)]
        [return: NativeTypeName("hb_tag_t")]
        [Obsolete]
        public static extern uint tag_from_language([NativeTypeName("hb_language_t")] nint language);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_get_axes", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        [Obsolete]
        public static extern uint var_get_axes([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* axes_count, hb_ot_var_axis_t* axes_array);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_find_axis", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        [Obsolete]
        public static extern int var_find_axis([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint axis_tag, [NativeTypeName("unsigned int *")] uint* axis_index, hb_ot_var_axis_t* axis_info);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_font_set_funcs", ExactSpelling = true)]
        public static extern void font_set_funcs([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_tags_from_script_and_language", ExactSpelling = true)]
        public static extern void tags_from_script_and_language(hb_script_t script, [NativeTypeName("hb_language_t")] nint language, [NativeTypeName("unsigned int *")] uint* script_count, [NativeTypeName("hb_tag_t *")] uint* script_tags, [NativeTypeName("unsigned int *")] uint* language_count, [NativeTypeName("hb_tag_t *")] uint* language_tags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_tag_to_script", ExactSpelling = true)]
        public static extern hb_script_t tag_to_script([NativeTypeName("hb_tag_t")] uint tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_tag_to_language", ExactSpelling = true)]
        [return: NativeTypeName("hb_language_t")]
        public static extern nint tag_to_language([NativeTypeName("hb_tag_t")] uint tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_tags_to_script_and_language", ExactSpelling = true)]
        public static extern void tags_to_script_and_language([NativeTypeName("hb_tag_t")] uint script_tag, [NativeTypeName("hb_tag_t")] uint language_tag, hb_script_t* script, [NativeTypeName("hb_language_t *")] nint* language);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_has_glyph_classes", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_has_glyph_classes([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_glyph_class", ExactSpelling = true)]
        public static extern hb_ot_layout_glyph_class_t layout_get_glyph_class([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_codepoint_t")] uint glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_glyphs_in_class", ExactSpelling = true)]
        public static extern void layout_get_glyphs_in_class([NativeTypeName("hb_face_t*")] nint face, hb_ot_layout_glyph_class_t klass, [NativeTypeName("hb_set_t*")] nint glyphs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_attach_points", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_get_attach_points([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* point_count, [NativeTypeName("unsigned int *")] uint* point_array);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_ligature_carets", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_get_ligature_carets([NativeTypeName("hb_font_t*")] nint font, hb_direction_t direction, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* caret_count, [NativeTypeName("hb_position_t *")] int* caret_array);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_table_get_script_tags", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_table_get_script_tags([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* script_count, [NativeTypeName("hb_tag_t *")] uint* script_tags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_table_find_script", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_table_find_script([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("hb_tag_t")] uint script_tag, [NativeTypeName("unsigned int *")] uint* script_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_table_select_script", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_table_select_script([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_count, [NativeTypeName("const hb_tag_t *")] uint* script_tags, [NativeTypeName("unsigned int *")] uint* script_index, [NativeTypeName("hb_tag_t *")] uint* chosen_script);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_table_get_feature_tags", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_table_get_feature_tags([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* feature_count, [NativeTypeName("hb_tag_t *")] uint* feature_tags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_script_get_language_tags", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_script_get_language_tags([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_index, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* language_count, [NativeTypeName("hb_tag_t *")] uint* language_tags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_script_select_language", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_script_select_language([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_index, [NativeTypeName("unsigned int")] uint language_count, [NativeTypeName("const hb_tag_t *")] uint* language_tags, [NativeTypeName("unsigned int *")] uint* language_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_script_select_language2", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_script_select_language2([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_index, [NativeTypeName("unsigned int")] uint language_count, [NativeTypeName("const hb_tag_t *")] uint* language_tags, [NativeTypeName("unsigned int *")] uint* language_index, [NativeTypeName("hb_tag_t *")] uint* chosen_language);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_language_get_required_feature_index", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_language_get_required_feature_index([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_index, [NativeTypeName("unsigned int")] uint language_index, [NativeTypeName("unsigned int *")] uint* feature_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_language_get_required_feature", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_language_get_required_feature([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_index, [NativeTypeName("unsigned int")] uint language_index, [NativeTypeName("unsigned int *")] uint* feature_index, [NativeTypeName("hb_tag_t *")] uint* feature_tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_language_get_feature_indexes", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_language_get_feature_indexes([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_index, [NativeTypeName("unsigned int")] uint language_index, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* feature_count, [NativeTypeName("unsigned int *")] uint* feature_indexes);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_language_get_feature_tags", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_language_get_feature_tags([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_index, [NativeTypeName("unsigned int")] uint language_index, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* feature_count, [NativeTypeName("hb_tag_t *")] uint* feature_tags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_language_find_feature", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_language_find_feature([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_index, [NativeTypeName("unsigned int")] uint language_index, [NativeTypeName("hb_tag_t")] uint feature_tag, [NativeTypeName("unsigned int *")] uint* feature_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_feature_get_lookups", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_feature_get_lookups([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint feature_index, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* lookup_count, [NativeTypeName("unsigned int *")] uint* lookup_indexes);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_table_get_lookup_count", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_table_get_lookup_count([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_collect_features", ExactSpelling = true)]
        public static extern void layout_collect_features([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("const hb_tag_t *")] uint* scripts, [NativeTypeName("const hb_tag_t *")] uint* languages, [NativeTypeName("const hb_tag_t *")] uint* features, [NativeTypeName("hb_set_t*")] nint feature_indexes);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_collect_features_map", ExactSpelling = true)]
        public static extern void layout_collect_features_map([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint script_index, [NativeTypeName("unsigned int")] uint language_index, [NativeTypeName("hb_map_t*")] nint feature_map);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_collect_lookups", ExactSpelling = true)]
        public static extern void layout_collect_lookups([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("const hb_tag_t *")] uint* scripts, [NativeTypeName("const hb_tag_t *")] uint* languages, [NativeTypeName("const hb_tag_t *")] uint* features, [NativeTypeName("hb_set_t*")] nint lookup_indexes);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_lookup_collect_glyphs", ExactSpelling = true)]
        public static extern void layout_lookup_collect_glyphs([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint lookup_index, [NativeTypeName("hb_set_t*")] nint glyphs_before, [NativeTypeName("hb_set_t*")] nint glyphs_input, [NativeTypeName("hb_set_t*")] nint glyphs_after, [NativeTypeName("hb_set_t*")] nint glyphs_output);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_table_find_feature_variations", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_table_find_feature_variations([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("const int *")] int* coords, [NativeTypeName("unsigned int")] uint num_coords, [NativeTypeName("unsigned int *")] uint* variations_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_feature_with_variations_get_lookups", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_feature_with_variations_get_lookups([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint feature_index, [NativeTypeName("unsigned int")] uint variations_index, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* lookup_count, [NativeTypeName("unsigned int *")] uint* lookup_indexes);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_has_substitution", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_has_substitution([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_lookup_get_glyph_alternates", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_lookup_get_glyph_alternates([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint lookup_index, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* alternate_count, [NativeTypeName("hb_codepoint_t *")] uint* alternate_glyphs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_lookup_would_substitute", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_lookup_would_substitute([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint lookup_index, [NativeTypeName("const hb_codepoint_t *")] uint* glyphs, [NativeTypeName("unsigned int")] uint glyphs_length, [NativeTypeName("hb_bool_t")] int zero_context);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_lookup_substitute_closure", ExactSpelling = true)]
        public static extern void layout_lookup_substitute_closure([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint lookup_index, [NativeTypeName("hb_set_t*")] nint glyphs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_lookups_substitute_closure", ExactSpelling = true)]
        public static extern void layout_lookups_substitute_closure([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("const hb_set_t *")] nint lookups, [NativeTypeName("hb_set_t*")] nint glyphs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_has_positioning", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_has_positioning([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_size_params", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_get_size_params([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int *")] uint* design_size, [NativeTypeName("unsigned int *")] uint* subfamily_id, [NativeTypeName("hb_ot_name_id_t *")] uint* subfamily_name_id, [NativeTypeName("unsigned int *")] uint* range_start, [NativeTypeName("unsigned int *")] uint* range_end);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_lookup_get_optical_bound", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int layout_lookup_get_optical_bound([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int")] uint lookup_index, hb_direction_t direction, [NativeTypeName("hb_codepoint_t")] uint glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_feature_get_name_ids", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_feature_get_name_ids([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint feature_index, [NativeTypeName("hb_ot_name_id_t *")] uint* label_id, [NativeTypeName("hb_ot_name_id_t *")] uint* tooltip_id, [NativeTypeName("hb_ot_name_id_t *")] uint* sample_id, [NativeTypeName("unsigned int *")] uint* num_named_parameters, [NativeTypeName("hb_ot_name_id_t *")] uint* first_param_id);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_feature_get_characters", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint layout_feature_get_characters([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("unsigned int")] uint feature_index, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* char_count, [NativeTypeName("hb_codepoint_t *")] uint* characters);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_font_extents", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_get_font_extents([NativeTypeName("hb_font_t*")] nint font, hb_direction_t direction, [NativeTypeName("hb_tag_t")] uint script_tag, [NativeTypeName("hb_tag_t")] uint language_tag, hb_font_extents_t* extents);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_font_extents2", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_get_font_extents2([NativeTypeName("hb_font_t*")] nint font, hb_direction_t direction, hb_script_t script, [NativeTypeName("hb_language_t")] nint language, hb_font_extents_t* extents);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_horizontal_baseline_tag_for_script", ExactSpelling = true)]
        public static extern hb_ot_layout_baseline_tag_t layout_get_horizontal_baseline_tag_for_script(hb_script_t script);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_baseline", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_get_baseline([NativeTypeName("hb_font_t*")] nint font, hb_ot_layout_baseline_tag_t baseline_tag, hb_direction_t direction, [NativeTypeName("hb_tag_t")] uint script_tag, [NativeTypeName("hb_tag_t")] uint language_tag, [NativeTypeName("hb_position_t *")] int* coord);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_baseline2", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int layout_get_baseline2([NativeTypeName("hb_font_t*")] nint font, hb_ot_layout_baseline_tag_t baseline_tag, hb_direction_t direction, hb_script_t script, [NativeTypeName("hb_language_t")] nint language, [NativeTypeName("hb_position_t *")] int* coord);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_baseline_with_fallback", ExactSpelling = true)]
        public static extern void layout_get_baseline_with_fallback([NativeTypeName("hb_font_t*")] nint font, hb_ot_layout_baseline_tag_t baseline_tag, hb_direction_t direction, [NativeTypeName("hb_tag_t")] uint script_tag, [NativeTypeName("hb_tag_t")] uint language_tag, [NativeTypeName("hb_position_t *")] int* coord);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_layout_get_baseline_with_fallback2", ExactSpelling = true)]
        public static extern void layout_get_baseline_with_fallback2([NativeTypeName("hb_font_t*")] nint font, hb_ot_layout_baseline_tag_t baseline_tag, hb_direction_t direction, hb_script_t script, [NativeTypeName("hb_language_t")] nint language, [NativeTypeName("hb_position_t *")] int* coord);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_math_has_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int math_has_data([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_math_get_constant", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int math_get_constant([NativeTypeName("hb_font_t*")] nint font, hb_ot_math_constant_t constant);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_math_get_glyph_italics_correction", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int math_get_glyph_italics_correction([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_math_get_glyph_top_accent_attachment", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int math_get_glyph_top_accent_attachment([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_math_is_glyph_extended_shape", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int math_is_glyph_extended_shape([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_codepoint_t")] uint glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_math_get_glyph_kerning", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int math_get_glyph_kerning([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, hb_ot_math_kern_t kern, [NativeTypeName("hb_position_t")] int correction_height);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_math_get_glyph_kernings", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint math_get_glyph_kernings([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, hb_ot_math_kern_t kern, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* entries_count, hb_ot_math_kern_entry_t* kern_entries);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_math_get_glyph_variants", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint math_get_glyph_variants([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, hb_direction_t direction, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* variants_count, hb_ot_math_glyph_variant_t* variants);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_math_get_min_connector_overlap", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int math_get_min_connector_overlap([NativeTypeName("hb_font_t*")] nint font, hb_direction_t direction);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_math_get_glyph_assembly", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint math_get_glyph_assembly([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, hb_direction_t direction, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* parts_count, hb_ot_math_glyph_part_t* parts, [NativeTypeName("hb_position_t *")] int* italics_correction);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_meta_get_entry_tags", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint meta_get_entry_tags([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* entries_count, hb_ot_meta_tag_t* entries);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_meta_reference_entry", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint meta_reference_entry([NativeTypeName("hb_face_t*")] nint face, hb_ot_meta_tag_t meta_tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_metrics_get_position", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int metrics_get_position([NativeTypeName("hb_font_t*")] nint font, hb_ot_metrics_tag_t metrics_tag, [NativeTypeName("hb_position_t *")] int* position);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_metrics_get_position_with_fallback", ExactSpelling = true)]
        public static extern void metrics_get_position_with_fallback([NativeTypeName("hb_font_t*")] nint font, hb_ot_metrics_tag_t metrics_tag, [NativeTypeName("hb_position_t *")] int* position);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_metrics_get_variation", ExactSpelling = true)]
        public static extern float metrics_get_variation([NativeTypeName("hb_font_t*")] nint font, hb_ot_metrics_tag_t metrics_tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_metrics_get_x_variation", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int metrics_get_x_variation([NativeTypeName("hb_font_t*")] nint font, hb_ot_metrics_tag_t metrics_tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_metrics_get_y_variation", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int metrics_get_y_variation([NativeTypeName("hb_font_t*")] nint font, hb_ot_metrics_tag_t metrics_tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_shape_glyphs_closure", ExactSpelling = true)]
        public static extern void shape_glyphs_closure([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const hb_feature_t *")] hb_feature_t* features, [NativeTypeName("unsigned int")] uint num_features, [NativeTypeName("hb_set_t*")] nint glyphs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_shape_plan_collect_lookups", ExactSpelling = true)]
        public static extern void shape_plan_collect_lookups([NativeTypeName("hb_shape_plan_t*")] nint shape_plan, [NativeTypeName("hb_tag_t")] uint table_tag, [NativeTypeName("hb_set_t*")] nint lookup_indexes);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_shape_plan_get_feature_tags", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint shape_plan_get_feature_tags([NativeTypeName("hb_shape_plan_t*")] nint shape_plan, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* tag_count, [NativeTypeName("hb_tag_t *")] uint* tags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_has_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int var_has_data([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_get_axis_count", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint var_get_axis_count([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_get_axis_infos", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint var_get_axis_infos([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* axes_count, hb_ot_var_axis_info_t* axes_array);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_find_axis_info", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int var_find_axis_info([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint axis_tag, hb_ot_var_axis_info_t* axis_info);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_get_named_instance_count", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint var_get_named_instance_count([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_named_instance_get_subfamily_name_id", ExactSpelling = true)]
        [return: NativeTypeName("hb_ot_name_id_t")]
        public static extern uint var_named_instance_get_subfamily_name_id([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint instance_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_named_instance_get_postscript_name_id", ExactSpelling = true)]
        [return: NativeTypeName("hb_ot_name_id_t")]
        public static extern uint var_named_instance_get_postscript_name_id([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint instance_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_named_instance_get_design_coords", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint var_named_instance_get_design_coords([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint instance_index, [NativeTypeName("unsigned int *")] uint* coords_length, float* coords);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_normalize_variations", ExactSpelling = true)]
        public static extern void var_normalize_variations([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("const hb_variation_t *")] hb_variation_t* variations, [NativeTypeName("unsigned int")] uint variations_length, int* coords, [NativeTypeName("unsigned int")] uint coords_length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_ot_var_normalize_coords", ExactSpelling = true)]
        public static extern void var_normalize_coords([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint coords_length, [NativeTypeName("const float *")] float* design_coords, int* normalized_coords);

        [NativeTypeName("#define HB_MATH_GLYPH_PART_FLAG_EXTENDER HB_OT_MATH_GLYPH_PART_FLAG_EXTENDER")]
        public const hb_ot_math_glyph_part_flags_t HB_MATH_GLYPH_PART_FLAG_EXTENDER = HB_OT_MATH_GLYPH_PART_FLAG_EXTENDER;

        [NativeTypeName("#define HB_OT_MATH_SCRIPT HB_OT_TAG_MATH_SCRIPT")]
        public const uint HB_OT_MATH_SCRIPT = ((uint)((((uint)('m') & 0xFF) << 24) | (((uint)('a') & 0xFF) << 16) | (((uint)('t') & 0xFF) << 8) | ((uint)('h') & 0xFF)));

        [NativeTypeName("#define HB_OT_VAR_NO_AXIS_INDEX 0xFFFFFFFFu")]
        public const uint HB_OT_VAR_NO_AXIS_INDEX = 0xFFFFFFFFU;

        [NativeTypeName("#define HB_OT_TAG_BASE HB_TAG('B','A','S','E')")]
        public const uint HB_OT_TAG_BASE = ((uint)((((uint)('B') & 0xFF) << 24) | (((uint)('A') & 0xFF) << 16) | (((uint)('S') & 0xFF) << 8) | ((uint)('E') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_GDEF HB_TAG('G','D','E','F')")]
        public const uint HB_OT_TAG_GDEF = ((uint)((((uint)('G') & 0xFF) << 24) | (((uint)('D') & 0xFF) << 16) | (((uint)('E') & 0xFF) << 8) | ((uint)('F') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_GSUB HB_TAG('G','S','U','B')")]
        public const uint HB_OT_TAG_GSUB = ((uint)((((uint)('G') & 0xFF) << 24) | (((uint)('S') & 0xFF) << 16) | (((uint)('U') & 0xFF) << 8) | ((uint)('B') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_GPOS HB_TAG('G','P','O','S')")]
        public const uint HB_OT_TAG_GPOS = ((uint)((((uint)('G') & 0xFF) << 24) | (((uint)('P') & 0xFF) << 16) | (((uint)('O') & 0xFF) << 8) | ((uint)('S') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_JSTF HB_TAG('J','S','T','F')")]
        public const uint HB_OT_TAG_JSTF = ((uint)((((uint)('J') & 0xFF) << 24) | (((uint)('S') & 0xFF) << 16) | (((uint)('T') & 0xFF) << 8) | ((uint)('F') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_DEFAULT_SCRIPT HB_TAG ('D', 'F', 'L', 'T')")]
        public const uint HB_OT_TAG_DEFAULT_SCRIPT = ((uint)((((uint)('D') & 0xFF) << 24) | (((uint)('F') & 0xFF) << 16) | (((uint)('L') & 0xFF) << 8) | ((uint)('T') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_DEFAULT_LANGUAGE HB_TAG ('d', 'f', 'l', 't')")]
        public const uint HB_OT_TAG_DEFAULT_LANGUAGE = ((uint)((((uint)('d') & 0xFF) << 24) | (((uint)('f') & 0xFF) << 16) | (((uint)('l') & 0xFF) << 8) | ((uint)('t') & 0xFF)));

        [NativeTypeName("#define HB_OT_MAX_TAGS_PER_SCRIPT 3u")]
        public const uint HB_OT_MAX_TAGS_PER_SCRIPT = 3U;

        [NativeTypeName("#define HB_OT_MAX_TAGS_PER_LANGUAGE 3u")]
        public const uint HB_OT_MAX_TAGS_PER_LANGUAGE = 3U;

        [NativeTypeName("#define HB_OT_LAYOUT_NO_SCRIPT_INDEX 0xFFFFu")]
        public const uint HB_OT_LAYOUT_NO_SCRIPT_INDEX = 0xFFFFU;

        [NativeTypeName("#define HB_OT_LAYOUT_NO_FEATURE_INDEX 0xFFFFu")]
        public const uint HB_OT_LAYOUT_NO_FEATURE_INDEX = 0xFFFFU;

        [NativeTypeName("#define HB_OT_LAYOUT_DEFAULT_LANGUAGE_INDEX 0xFFFFu")]
        public const uint HB_OT_LAYOUT_DEFAULT_LANGUAGE_INDEX = 0xFFFFU;

        [NativeTypeName("#define HB_OT_LAYOUT_NO_VARIATIONS_INDEX 0xFFFFFFFFu")]
        public const uint HB_OT_LAYOUT_NO_VARIATIONS_INDEX = 0xFFFFFFFFU;

        [NativeTypeName("#define HB_OT_TAG_MATH HB_TAG('M','A','T','H')")]
        public const uint HB_OT_TAG_MATH = ((uint)((((uint)('M') & 0xFF) << 24) | (((uint)('A') & 0xFF) << 16) | (((uint)('T') & 0xFF) << 8) | ((uint)('H') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_MATH_SCRIPT HB_TAG('m','a','t','h')")]
        public const uint HB_OT_TAG_MATH_SCRIPT = ((uint)((((uint)('m') & 0xFF) << 24) | (((uint)('a') & 0xFF) << 16) | (((uint)('t') & 0xFF) << 8) | ((uint)('h') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_VAR_AXIS_ITALIC HB_TAG('i','t','a','l')")]
        public const uint HB_OT_TAG_VAR_AXIS_ITALIC = ((uint)((((uint)('i') & 0xFF) << 24) | (((uint)('t') & 0xFF) << 16) | (((uint)('a') & 0xFF) << 8) | ((uint)('l') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_VAR_AXIS_OPTICAL_SIZE HB_TAG('o','p','s','z')")]
        public const uint HB_OT_TAG_VAR_AXIS_OPTICAL_SIZE = ((uint)((((uint)('o') & 0xFF) << 24) | (((uint)('p') & 0xFF) << 16) | (((uint)('s') & 0xFF) << 8) | ((uint)('z') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_VAR_AXIS_SLANT HB_TAG('s','l','n','t')")]
        public const uint HB_OT_TAG_VAR_AXIS_SLANT = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('l') & 0xFF) << 16) | (((uint)('n') & 0xFF) << 8) | ((uint)('t') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_VAR_AXIS_WIDTH HB_TAG('w','d','t','h')")]
        public const uint HB_OT_TAG_VAR_AXIS_WIDTH = ((uint)((((uint)('w') & 0xFF) << 24) | (((uint)('d') & 0xFF) << 16) | (((uint)('t') & 0xFF) << 8) | ((uint)('h') & 0xFF)));

        [NativeTypeName("#define HB_OT_TAG_VAR_AXIS_WEIGHT HB_TAG('w','g','h','t')")]
        public const uint HB_OT_TAG_VAR_AXIS_WEIGHT = ((uint)((((uint)('w') & 0xFF) << 24) | (((uint)('g') & 0xFF) << 16) | (((uint)('h') & 0xFF) << 8) | ((uint)('t') & 0xFF)));
    }
}
