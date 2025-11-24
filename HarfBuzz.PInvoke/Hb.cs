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
using static HarfBuzz.PInvoke.hb_script_t;

namespace HarfBuzz.PInvoke
{
    public static unsafe partial class Hb
    {
        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_tag_from_string", ExactSpelling = true)]
        [return: NativeTypeName("hb_tag_t")]
        public static extern uint tag_from_string([NativeTypeName("const char *")] byte* str, int len);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_tag_to_string", ExactSpelling = true)]
        public static extern void tag_to_string([NativeTypeName("hb_tag_t")] uint tag, [NativeTypeName("char *")] byte* buf);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_direction_from_string", ExactSpelling = true)]
        public static extern hb_direction_t direction_from_string([NativeTypeName("const char *")] byte* str, int len);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_direction_to_string", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* direction_to_string(hb_direction_t direction);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_language_from_string", ExactSpelling = true)]
        [return: NativeTypeName("hb_language_t")]
        public static extern nint language_from_string([NativeTypeName("const char *")] byte* str, int len);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_language_to_string", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* language_to_string([NativeTypeName("hb_language_t")] nint language);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_language_get_default", ExactSpelling = true)]
        [return: NativeTypeName("hb_language_t")]
        public static extern nint language_get_default();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_language_matches", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int language_matches([NativeTypeName("hb_language_t")] nint language, [NativeTypeName("hb_language_t")] nint specific);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_script_from_iso15924_tag", ExactSpelling = true)]
        public static extern hb_script_t script_from_iso15924_tag([NativeTypeName("hb_tag_t")] uint tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_script_from_string", ExactSpelling = true)]
        public static extern hb_script_t script_from_string([NativeTypeName("const char *")] byte* str, int len);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_script_to_iso15924_tag", ExactSpelling = true)]
        [return: NativeTypeName("hb_tag_t")]
        public static extern uint script_to_iso15924_tag(hb_script_t script);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_script_get_horizontal_direction", ExactSpelling = true)]
        public static extern hb_direction_t script_get_horizontal_direction(hb_script_t script);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_feature_from_string", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int feature_from_string([NativeTypeName("const char *")] byte* str, int len, hb_feature_t* feature);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_feature_to_string", ExactSpelling = true)]
        public static extern void feature_to_string(hb_feature_t* feature, [NativeTypeName("char *")] byte* buf, [NativeTypeName("unsigned int")] uint size);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_variation_from_string", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int variation_from_string([NativeTypeName("const char *")] byte* str, int len, hb_variation_t* variation);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_variation_to_string", ExactSpelling = true)]
        public static extern void variation_to_string(hb_variation_t* variation, [NativeTypeName("char *")] byte* buf, [NativeTypeName("unsigned int")] uint size);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_color_get_alpha", ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte color_get_alpha([NativeTypeName("hb_color_t")] uint color);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_color_get_red", ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte color_get_red([NativeTypeName("hb_color_t")] uint color);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_color_get_green", ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte color_get_green([NativeTypeName("hb_color_t")] uint color);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_color_get_blue", ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte color_get_blue([NativeTypeName("hb_color_t")] uint color);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_malloc", ExactSpelling = true)]
        public static extern void* malloc([NativeTypeName("size_t")] nuint size);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_calloc", ExactSpelling = true)]
        public static extern void* calloc([NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_realloc", ExactSpelling = true)]
        public static extern void* realloc(void* ptr, [NativeTypeName("size_t")] nuint size);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_free", ExactSpelling = true)]
        public static extern void free(void* ptr);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint blob_create([NativeTypeName("const char *")] byte* data, [NativeTypeName("unsigned int")] uint length, hb_memory_mode_t mode, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_create_or_fail", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint blob_create_or_fail([NativeTypeName("const char *")] byte* data, [NativeTypeName("unsigned int")] uint length, hb_memory_mode_t mode, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_create_from_file", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint blob_create_from_file([NativeTypeName("const char *")] byte* file_name);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_create_from_file_or_fail", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint blob_create_from_file_or_fail([NativeTypeName("const char *")] byte* file_name);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_create_sub_blob", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint blob_create_sub_blob([NativeTypeName("hb_blob_t*")] nint parent, [NativeTypeName("unsigned int")] uint offset, [NativeTypeName("unsigned int")] uint length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_copy_writable_or_fail", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint blob_copy_writable_or_fail([NativeTypeName("hb_blob_t*")] nint blob);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint blob_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint blob_reference([NativeTypeName("hb_blob_t*")] nint blob);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_destroy", ExactSpelling = true)]
        public static extern void blob_destroy([NativeTypeName("hb_blob_t*")] nint blob);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int blob_set_user_data([NativeTypeName("hb_blob_t*")] nint blob, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_get_user_data", ExactSpelling = true)]
        public static extern void* blob_get_user_data([NativeTypeName("const hb_blob_t *")] nint blob, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_make_immutable", ExactSpelling = true)]
        public static extern void blob_make_immutable([NativeTypeName("hb_blob_t*")] nint blob);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_is_immutable", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int blob_is_immutable([NativeTypeName("hb_blob_t*")] nint blob);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_get_length", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint blob_get_length([NativeTypeName("hb_blob_t*")] nint blob);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_get_data", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* blob_get_data([NativeTypeName("hb_blob_t*")] nint blob, [NativeTypeName("unsigned int *")] uint* length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_blob_get_data_writable", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* blob_get_data_writable([NativeTypeName("hb_blob_t*")] nint blob, [NativeTypeName("unsigned int *")] uint* length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_get_default", ExactSpelling = true)]
        [return: NativeTypeName("hb_unicode_funcs_t*")]
        public static extern nint unicode_funcs_get_default();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_unicode_funcs_t*")]
        public static extern nint unicode_funcs_create([NativeTypeName("hb_unicode_funcs_t*")] nint parent);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_unicode_funcs_t*")]
        public static extern nint unicode_funcs_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_unicode_funcs_t*")]
        public static extern nint unicode_funcs_reference([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_destroy", ExactSpelling = true)]
        public static extern void unicode_funcs_destroy([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int unicode_funcs_set_user_data([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_get_user_data", ExactSpelling = true)]
        public static extern void* unicode_funcs_get_user_data([NativeTypeName("const hb_unicode_funcs_t *")] nint ufuncs, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_make_immutable", ExactSpelling = true)]
        public static extern void unicode_funcs_make_immutable([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_is_immutable", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int unicode_funcs_is_immutable([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_get_parent", ExactSpelling = true)]
        [return: NativeTypeName("hb_unicode_funcs_t*")]
        public static extern nint unicode_funcs_get_parent([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_set_combining_class_func", ExactSpelling = true)]
        public static extern void unicode_funcs_set_combining_class_func([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_unicode_combining_class_func_t")] delegate* unmanaged[Cdecl]<nint, uint, void*, hb_unicode_combining_class_t> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_set_general_category_func", ExactSpelling = true)]
        public static extern void unicode_funcs_set_general_category_func([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_unicode_general_category_func_t")] delegate* unmanaged[Cdecl]<nint, uint, void*, hb_unicode_general_category_t> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_set_mirroring_func", ExactSpelling = true)]
        public static extern void unicode_funcs_set_mirroring_func([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_unicode_mirroring_func_t")] delegate* unmanaged[Cdecl]<nint, uint, void*, uint> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_set_script_func", ExactSpelling = true)]
        public static extern void unicode_funcs_set_script_func([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_unicode_script_func_t")] delegate* unmanaged[Cdecl]<nint, uint, void*, hb_script_t> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_set_compose_func", ExactSpelling = true)]
        public static extern void unicode_funcs_set_compose_func([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_unicode_compose_func_t")] delegate* unmanaged[Cdecl]<nint, uint, uint, uint*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_set_decompose_func", ExactSpelling = true)]
        public static extern void unicode_funcs_set_decompose_func([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_unicode_decompose_func_t")] delegate* unmanaged[Cdecl]<nint, uint, uint*, uint*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_combining_class", ExactSpelling = true)]
        public static extern hb_unicode_combining_class_t unicode_combining_class([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_codepoint_t")] uint unicode);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_general_category", ExactSpelling = true)]
        public static extern hb_unicode_general_category_t unicode_general_category([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_codepoint_t")] uint unicode);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_mirroring", ExactSpelling = true)]
        [return: NativeTypeName("hb_codepoint_t")]
        public static extern uint unicode_mirroring([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_codepoint_t")] uint unicode);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_script", ExactSpelling = true)]
        public static extern hb_script_t unicode_script([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_codepoint_t")] uint unicode);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_compose", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int unicode_compose([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_codepoint_t")] uint a, [NativeTypeName("hb_codepoint_t")] uint b, [NativeTypeName("hb_codepoint_t *")] uint* ab);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_decompose", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int unicode_decompose([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_codepoint_t")] uint ab, [NativeTypeName("hb_codepoint_t *")] uint* a, [NativeTypeName("hb_codepoint_t *")] uint* b);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_set_t*")]
        public static extern nint set_create();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_set_t*")]
        public static extern nint set_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_set_t*")]
        public static extern nint set_reference([NativeTypeName("hb_set_t*")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_destroy", ExactSpelling = true)]
        public static extern void set_destroy([NativeTypeName("hb_set_t*")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_set_user_data([NativeTypeName("hb_set_t*")] nint set, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_get_user_data", ExactSpelling = true)]
        public static extern void* set_get_user_data([NativeTypeName("const hb_set_t *")] nint set, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_allocation_successful", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_allocation_successful([NativeTypeName("const hb_set_t *")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_copy", ExactSpelling = true)]
        [return: NativeTypeName("hb_set_t*")]
        public static extern nint set_copy([NativeTypeName("const hb_set_t *")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_clear", ExactSpelling = true)]
        public static extern void set_clear([NativeTypeName("hb_set_t*")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_is_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_is_empty([NativeTypeName("const hb_set_t *")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_invert", ExactSpelling = true)]
        public static extern void set_invert([NativeTypeName("hb_set_t*")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_is_inverted", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_is_inverted([NativeTypeName("const hb_set_t *")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_has", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_has([NativeTypeName("const hb_set_t *")] nint set, [NativeTypeName("hb_codepoint_t")] uint codepoint);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_add", ExactSpelling = true)]
        public static extern void set_add([NativeTypeName("hb_set_t*")] nint set, [NativeTypeName("hb_codepoint_t")] uint codepoint);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_add_range", ExactSpelling = true)]
        public static extern void set_add_range([NativeTypeName("hb_set_t*")] nint set, [NativeTypeName("hb_codepoint_t")] uint first, [NativeTypeName("hb_codepoint_t")] uint last);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_add_sorted_array", ExactSpelling = true)]
        public static extern void set_add_sorted_array([NativeTypeName("hb_set_t*")] nint set, [NativeTypeName("const hb_codepoint_t *")] uint* sorted_codepoints, [NativeTypeName("unsigned int")] uint num_codepoints);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_del", ExactSpelling = true)]
        public static extern void set_del([NativeTypeName("hb_set_t*")] nint set, [NativeTypeName("hb_codepoint_t")] uint codepoint);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_del_range", ExactSpelling = true)]
        public static extern void set_del_range([NativeTypeName("hb_set_t*")] nint set, [NativeTypeName("hb_codepoint_t")] uint first, [NativeTypeName("hb_codepoint_t")] uint last);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_is_equal", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_is_equal([NativeTypeName("const hb_set_t *")] nint set, [NativeTypeName("const hb_set_t *")] nint other);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_hash", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint set_hash([NativeTypeName("const hb_set_t *")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_is_subset", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_is_subset([NativeTypeName("const hb_set_t *")] nint set, [NativeTypeName("const hb_set_t *")] nint larger_set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_set", ExactSpelling = true)]
        public static extern void set_set([NativeTypeName("hb_set_t*")] nint set, [NativeTypeName("const hb_set_t *")] nint other);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_union", ExactSpelling = true)]
        public static extern void set_union([NativeTypeName("hb_set_t*")] nint set, [NativeTypeName("const hb_set_t *")] nint other);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_intersect", ExactSpelling = true)]
        public static extern void set_intersect([NativeTypeName("hb_set_t*")] nint set, [NativeTypeName("const hb_set_t *")] nint other);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_subtract", ExactSpelling = true)]
        public static extern void set_subtract([NativeTypeName("hb_set_t*")] nint set, [NativeTypeName("const hb_set_t *")] nint other);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_symmetric_difference", ExactSpelling = true)]
        public static extern void set_symmetric_difference([NativeTypeName("hb_set_t*")] nint set, [NativeTypeName("const hb_set_t *")] nint other);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_get_population", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint set_get_population([NativeTypeName("const hb_set_t *")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_get_min", ExactSpelling = true)]
        [return: NativeTypeName("hb_codepoint_t")]
        public static extern uint set_get_min([NativeTypeName("const hb_set_t *")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_get_max", ExactSpelling = true)]
        [return: NativeTypeName("hb_codepoint_t")]
        public static extern uint set_get_max([NativeTypeName("const hb_set_t *")] nint set);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_next", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_next([NativeTypeName("const hb_set_t *")] nint set, [NativeTypeName("hb_codepoint_t *")] uint* codepoint);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_previous", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_previous([NativeTypeName("const hb_set_t *")] nint set, [NativeTypeName("hb_codepoint_t *")] uint* codepoint);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_next_range", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_next_range([NativeTypeName("const hb_set_t *")] nint set, [NativeTypeName("hb_codepoint_t *")] uint* first, [NativeTypeName("hb_codepoint_t *")] uint* last);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_previous_range", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int set_previous_range([NativeTypeName("const hb_set_t *")] nint set, [NativeTypeName("hb_codepoint_t *")] uint* first, [NativeTypeName("hb_codepoint_t *")] uint* last);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_set_next_many", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint set_next_many([NativeTypeName("const hb_set_t *")] nint set, [NativeTypeName("hb_codepoint_t")] uint codepoint, [NativeTypeName("hb_codepoint_t *")] uint* @out, [NativeTypeName("unsigned int")] uint size);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_map_t*")]
        public static extern nint map_create();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_map_t*")]
        public static extern nint map_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_map_t*")]
        public static extern nint map_reference([NativeTypeName("hb_map_t*")] nint map);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_destroy", ExactSpelling = true)]
        public static extern void map_destroy([NativeTypeName("hb_map_t*")] nint map);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int map_set_user_data([NativeTypeName("hb_map_t*")] nint map, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_get_user_data", ExactSpelling = true)]
        public static extern void* map_get_user_data([NativeTypeName("const hb_map_t *")] nint map, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_allocation_successful", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int map_allocation_successful([NativeTypeName("const hb_map_t *")] nint map);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_copy", ExactSpelling = true)]
        [return: NativeTypeName("hb_map_t*")]
        public static extern nint map_copy([NativeTypeName("const hb_map_t *")] nint map);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_clear", ExactSpelling = true)]
        public static extern void map_clear([NativeTypeName("hb_map_t*")] nint map);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_is_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int map_is_empty([NativeTypeName("const hb_map_t *")] nint map);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_get_population", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint map_get_population([NativeTypeName("const hb_map_t *")] nint map);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_is_equal", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int map_is_equal([NativeTypeName("const hb_map_t *")] nint map, [NativeTypeName("const hb_map_t *")] nint other);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_hash", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint map_hash([NativeTypeName("const hb_map_t *")] nint map);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_set", ExactSpelling = true)]
        public static extern void map_set([NativeTypeName("hb_map_t*")] nint map, [NativeTypeName("hb_codepoint_t")] uint key, [NativeTypeName("hb_codepoint_t")] uint value);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_get", ExactSpelling = true)]
        [return: NativeTypeName("hb_codepoint_t")]
        public static extern uint map_get([NativeTypeName("const hb_map_t *")] nint map, [NativeTypeName("hb_codepoint_t")] uint key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_del", ExactSpelling = true)]
        public static extern void map_del([NativeTypeName("hb_map_t*")] nint map, [NativeTypeName("hb_codepoint_t")] uint key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_has", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int map_has([NativeTypeName("const hb_map_t *")] nint map, [NativeTypeName("hb_codepoint_t")] uint key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_update", ExactSpelling = true)]
        public static extern void map_update([NativeTypeName("hb_map_t*")] nint map, [NativeTypeName("const hb_map_t *")] nint other);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_next", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int map_next([NativeTypeName("const hb_map_t *")] nint map, int* idx, [NativeTypeName("hb_codepoint_t *")] uint* key, [NativeTypeName("hb_codepoint_t *")] uint* value);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_keys", ExactSpelling = true)]
        public static extern void map_keys([NativeTypeName("const hb_map_t *")] nint map, [NativeTypeName("hb_set_t*")] nint keys);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_map_values", ExactSpelling = true)]
        public static extern void map_values([NativeTypeName("const hb_map_t *")] nint map, [NativeTypeName("hb_set_t*")] nint values);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_count", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint face_count([NativeTypeName("hb_blob_t*")] nint blob);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint face_create([NativeTypeName("hb_blob_t*")] nint blob, [NativeTypeName("unsigned int")] uint index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_create_or_fail", ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint face_create_or_fail([NativeTypeName("hb_blob_t*")] nint blob, [NativeTypeName("unsigned int")] uint index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_create_or_fail_using", ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint face_create_or_fail_using([NativeTypeName("hb_blob_t*")] nint blob, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("const char *")] byte* loader_name);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_create_from_file_or_fail", ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint face_create_from_file_or_fail([NativeTypeName("const char *")] byte* file_name, [NativeTypeName("unsigned int")] uint index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_create_from_file_or_fail_using", ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint face_create_from_file_or_fail_using([NativeTypeName("const char *")] byte* file_name, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("const char *")] byte* loader_name);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_list_loaders", ExactSpelling = true)]
        [return: NativeTypeName("const char **")]
        public static extern byte** face_list_loaders();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_create_for_tables", ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint face_create_for_tables([NativeTypeName("hb_reference_table_func_t")] delegate* unmanaged[Cdecl]<nint, uint, void*, nint> reference_table_func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint face_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint face_reference([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_destroy", ExactSpelling = true)]
        public static extern void face_destroy([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int face_set_user_data([NativeTypeName("hb_face_t*")] nint face, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_get_user_data", ExactSpelling = true)]
        public static extern void* face_get_user_data([NativeTypeName("const hb_face_t *")] nint face, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_make_immutable", ExactSpelling = true)]
        public static extern void face_make_immutable([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_is_immutable", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int face_is_immutable([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_reference_table", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint face_reference_table([NativeTypeName("const hb_face_t *")] nint face, [NativeTypeName("hb_tag_t")] uint tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_reference_blob", ExactSpelling = true)]
        [return: NativeTypeName("hb_blob_t*")]
        public static extern nint face_reference_blob([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_set_index", ExactSpelling = true)]
        public static extern void face_set_index([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_get_index", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint face_get_index([NativeTypeName("const hb_face_t *")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_set_upem", ExactSpelling = true)]
        public static extern void face_set_upem([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint upem);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_get_upem", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint face_get_upem([NativeTypeName("const hb_face_t *")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_set_glyph_count", ExactSpelling = true)]
        public static extern void face_set_glyph_count([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("unsigned int")] uint glyph_count);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_get_glyph_count", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint face_get_glyph_count([NativeTypeName("const hb_face_t *")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_set_get_table_tags_func", ExactSpelling = true)]
        public static extern void face_set_get_table_tags_func([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_get_table_tags_func_t")] delegate* unmanaged[Cdecl]<nint, uint, uint*, uint*, void*, uint> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_get_table_tags", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint face_get_table_tags([NativeTypeName("const hb_face_t *")] nint face, [NativeTypeName("unsigned int")] uint start_offset, [NativeTypeName("unsigned int *")] uint* table_count, [NativeTypeName("hb_tag_t *")] uint* table_tags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_collect_unicodes", ExactSpelling = true)]
        public static extern void face_collect_unicodes([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_set_t*")] nint @out);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_collect_nominal_glyph_mapping", ExactSpelling = true)]
        public static extern void face_collect_nominal_glyph_mapping([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_map_t*")] nint mapping, [NativeTypeName("hb_set_t*")] nint unicodes);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_collect_variation_selectors", ExactSpelling = true)]
        public static extern void face_collect_variation_selectors([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_set_t*")] nint @out);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_collect_variation_unicodes", ExactSpelling = true)]
        public static extern void face_collect_variation_unicodes([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_codepoint_t")] uint variation_selector, [NativeTypeName("hb_set_t*")] nint @out);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_builder_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint face_builder_create();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_builder_add_table", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int face_builder_add_table([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("hb_tag_t")] uint tag, [NativeTypeName("hb_blob_t*")] nint blob);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_face_builder_sort_tables", ExactSpelling = true)]
        public static extern void face_builder_sort_tables([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("const hb_tag_t *")] uint* tags);

        [NativeTypeName("#define HB_CODEPOINT_INVALID ((hb_codepoint_t) -1)")]
        public const uint HB_CODEPOINT_INVALID = unchecked((uint)(-1));

        [NativeTypeName("#define HB_TAG_NONE HB_TAG(0,0,0,0)")]
        public const uint HB_TAG_NONE = ((uint)((((uint)(0) & 0xFF) << 24) | (((uint)(0) & 0xFF) << 16) | (((uint)(0) & 0xFF) << 8) | ((uint)(0) & 0xFF)));

        [NativeTypeName("#define HB_TAG_MAX HB_TAG(0xff,0xff,0xff,0xff)")]
        public const uint HB_TAG_MAX = ((uint)((((uint)(0xff) & 0xFF) << 24) | (((uint)(0xff) & 0xFF) << 16) | (((uint)(0xff) & 0xFF) << 8) | ((uint)(0xff) & 0xFF)));

        [NativeTypeName("#define HB_TAG_MAX_SIGNED HB_TAG(0x7f,0xff,0xff,0xff)")]
        public const uint HB_TAG_MAX_SIGNED = ((uint)((((uint)(0x7f) & 0xFF) << 24) | (((uint)(0xff) & 0xFF) << 16) | (((uint)(0xff) & 0xFF) << 8) | ((uint)(0xff) & 0xFF)));

        [NativeTypeName("#define HB_LANGUAGE_INVALID ((hb_language_t) 0)")]
        public static nint HB_LANGUAGE_INVALID => ((nint)(0));

        [NativeTypeName("#define HB_FEATURE_GLOBAL_START 0")]
        public const int HB_FEATURE_GLOBAL_START = 0;

        [NativeTypeName("#define HB_FEATURE_GLOBAL_END ((unsigned int) -1)")]
        public const uint HB_FEATURE_GLOBAL_END = unchecked((uint)(-1));

        [NativeTypeName("#define HB_UNICODE_MAX 0x10FFFFu")]
        public const uint HB_UNICODE_MAX = 0x10FFFFU;

        [NativeTypeName("#define HB_SET_VALUE_INVALID HB_CODEPOINT_INVALID")]
        public const uint HB_SET_VALUE_INVALID = unchecked((uint)(-1));

        [NativeTypeName("#define HB_MAP_VALUE_INVALID HB_CODEPOINT_INVALID")]
        public const uint HB_MAP_VALUE_INVALID = unchecked((uint)(-1));

        [NativeTypeName("#define HB_PAINT_IMAGE_FORMAT_PNG HB_TAG('p','n','g',' ')")]
        public const uint HB_PAINT_IMAGE_FORMAT_PNG = ((uint)((((uint)('p') & 0xFF) << 24) | (((uint)('n') & 0xFF) << 16) | (((uint)('g') & 0xFF) << 8) | ((uint)(' ') & 0xFF)));

        [NativeTypeName("#define HB_PAINT_IMAGE_FORMAT_SVG HB_TAG('s','v','g',' ')")]
        public const uint HB_PAINT_IMAGE_FORMAT_SVG = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('v') & 0xFF) << 16) | (((uint)('g') & 0xFF) << 8) | ((uint)(' ') & 0xFF)));

        [NativeTypeName("#define HB_PAINT_IMAGE_FORMAT_BGRA HB_TAG('B','G','R','A')")]
        public const uint HB_PAINT_IMAGE_FORMAT_BGRA = ((uint)((((uint)('B') & 0xFF) << 24) | (((uint)('G') & 0xFF) << 16) | (((uint)('R') & 0xFF) << 8) | ((uint)('A') & 0xFF)));

        [NativeTypeName("#define HB_FONT_NO_VAR_NAMED_INSTANCE 0xFFFFFFFF")]
        public const uint HB_FONT_NO_VAR_NAMED_INSTANCE = 0xFFFFFFFF;

        [NativeTypeName("#define HB_BUFFER_REPLACEMENT_CODEPOINT_DEFAULT 0xFFFDu")]
        public const uint HB_BUFFER_REPLACEMENT_CODEPOINT_DEFAULT = 0xFFFDU;

        [NativeTypeName("#define HB_SCRIPT_CANADIAN_ABORIGINAL HB_SCRIPT_CANADIAN_SYLLABICS")]
        public const hb_script_t HB_SCRIPT_CANADIAN_ABORIGINAL = HB_SCRIPT_CANADIAN_SYLLABICS;

        [NativeTypeName("#define HB_UNICODE_COMBINING_CLASS_CCC133 133")]
        public const int HB_UNICODE_COMBINING_CLASS_CCC133 = 133;

        [NativeTypeName("#define HB_UNICODE_MAX_DECOMPOSITION_LEN (18+1)")]
        public const int HB_UNICODE_MAX_DECOMPOSITION_LEN = (18 + 1);

        [NativeTypeName("#define HB_VERSION_MAJOR 11")]
        public const int HB_VERSION_MAJOR = 11;

        [NativeTypeName("#define HB_VERSION_MINOR 5")]
        public const int HB_VERSION_MINOR = 5;

        [NativeTypeName("#define HB_VERSION_MICRO 1")]
        public const int HB_VERSION_MICRO = 1;

        [NativeTypeName("#define HB_VERSION_STRING \"11.5.1\"")]
        public static ReadOnlySpan<byte> HB_VERSION_STRING => "11.5.1"u8;

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_set_move_to_func", ExactSpelling = true)]
        public static extern void draw_funcs_set_move_to_func([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, [NativeTypeName("hb_draw_move_to_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_draw_state_t*, float, float, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_set_line_to_func", ExactSpelling = true)]
        public static extern void draw_funcs_set_line_to_func([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, [NativeTypeName("hb_draw_line_to_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_draw_state_t*, float, float, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_set_quadratic_to_func", ExactSpelling = true)]
        public static extern void draw_funcs_set_quadratic_to_func([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, [NativeTypeName("hb_draw_quadratic_to_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_draw_state_t*, float, float, float, float, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_set_cubic_to_func", ExactSpelling = true)]
        public static extern void draw_funcs_set_cubic_to_func([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, [NativeTypeName("hb_draw_cubic_to_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_draw_state_t*, float, float, float, float, float, float, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_set_close_path_func", ExactSpelling = true)]
        public static extern void draw_funcs_set_close_path_func([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, [NativeTypeName("hb_draw_close_path_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_draw_state_t*, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_draw_funcs_t*")]
        public static extern nint draw_funcs_create();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_draw_funcs_t*")]
        public static extern nint draw_funcs_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_draw_funcs_t*")]
        public static extern nint draw_funcs_reference([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_destroy", ExactSpelling = true)]
        public static extern void draw_funcs_destroy([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int draw_funcs_set_user_data([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_get_user_data", ExactSpelling = true)]
        public static extern void* draw_funcs_get_user_data([NativeTypeName("const hb_draw_funcs_t *")] nint dfuncs, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_make_immutable", ExactSpelling = true)]
        public static extern void draw_funcs_make_immutable([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_funcs_is_immutable", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int draw_funcs_is_immutable([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_move_to", ExactSpelling = true)]
        public static extern void draw_move_to([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, void* draw_data, hb_draw_state_t* st, float to_x, float to_y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_line_to", ExactSpelling = true)]
        public static extern void draw_line_to([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, void* draw_data, hb_draw_state_t* st, float to_x, float to_y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_quadratic_to", ExactSpelling = true)]
        public static extern void draw_quadratic_to([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, void* draw_data, hb_draw_state_t* st, float control_x, float control_y, float to_x, float to_y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_cubic_to", ExactSpelling = true)]
        public static extern void draw_cubic_to([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, void* draw_data, hb_draw_state_t* st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_draw_close_path", ExactSpelling = true)]
        public static extern void draw_close_path([NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, void* draw_data, hb_draw_state_t* st);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_paint_funcs_t*")]
        public static extern nint paint_funcs_create();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_paint_funcs_t*")]
        public static extern nint paint_funcs_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_paint_funcs_t*")]
        public static extern nint paint_funcs_reference([NativeTypeName("hb_paint_funcs_t*")] nint funcs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_destroy", ExactSpelling = true)]
        public static extern void paint_funcs_destroy([NativeTypeName("hb_paint_funcs_t*")] nint funcs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int paint_funcs_set_user_data([NativeTypeName("hb_paint_funcs_t*")] nint funcs, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_get_user_data", ExactSpelling = true)]
        public static extern void* paint_funcs_get_user_data([NativeTypeName("const hb_paint_funcs_t *")] nint funcs, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_make_immutable", ExactSpelling = true)]
        public static extern void paint_funcs_make_immutable([NativeTypeName("hb_paint_funcs_t*")] nint funcs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_is_immutable", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int paint_funcs_is_immutable([NativeTypeName("hb_paint_funcs_t*")] nint funcs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_color_line_get_color_stops", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint color_line_get_color_stops(hb_color_line_t* color_line, [NativeTypeName("unsigned int")] uint start, [NativeTypeName("unsigned int *")] uint* count, hb_color_stop_t* color_stops);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_color_line_get_extend", ExactSpelling = true)]
        public static extern hb_paint_extend_t color_line_get_extend(hb_color_line_t* color_line);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_push_transform_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_push_transform_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_push_transform_func_t")] delegate* unmanaged[Cdecl]<nint, void*, float, float, float, float, float, float, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_pop_transform_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_pop_transform_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_pop_transform_func_t")] delegate* unmanaged[Cdecl]<nint, void*, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_color_glyph_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_color_glyph_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_color_glyph_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, nint, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_push_clip_glyph_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_push_clip_glyph_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_push_clip_glyph_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, nint, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_push_clip_rectangle_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_push_clip_rectangle_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_push_clip_rectangle_func_t")] delegate* unmanaged[Cdecl]<nint, void*, float, float, float, float, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_pop_clip_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_pop_clip_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_pop_clip_func_t")] delegate* unmanaged[Cdecl]<nint, void*, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_color_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_color_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_color_func_t")] delegate* unmanaged[Cdecl]<nint, void*, int, uint, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_image_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_image_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_image_func_t")] delegate* unmanaged[Cdecl]<nint, void*, nint, uint, uint, uint, float, hb_glyph_extents_t*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_linear_gradient_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_linear_gradient_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_linear_gradient_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_color_line_t*, float, float, float, float, float, float, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_radial_gradient_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_radial_gradient_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_radial_gradient_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_color_line_t*, float, float, float, float, float, float, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_sweep_gradient_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_sweep_gradient_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_sweep_gradient_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_color_line_t*, float, float, float, float, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_push_group_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_push_group_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_push_group_func_t")] delegate* unmanaged[Cdecl]<nint, void*, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_pop_group_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_pop_group_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_pop_group_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_paint_composite_mode_t, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_funcs_set_custom_palette_color_func", ExactSpelling = true)]
        public static extern void paint_funcs_set_custom_palette_color_func([NativeTypeName("hb_paint_funcs_t*")] nint funcs, [NativeTypeName("hb_paint_custom_palette_color_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_push_transform", ExactSpelling = true)]
        public static extern void paint_push_transform([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, float xx, float yx, float xy, float yy, float dx, float dy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_push_font_transform", ExactSpelling = true)]
        public static extern void paint_push_font_transform([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, [NativeTypeName("const hb_font_t *")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_push_inverse_font_transform", ExactSpelling = true)]
        public static extern void paint_push_inverse_font_transform([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, [NativeTypeName("const hb_font_t *")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_pop_transform", ExactSpelling = true)]
        public static extern void paint_pop_transform([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_color_glyph", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int paint_color_glyph([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_push_clip_glyph", ExactSpelling = true)]
        public static extern void paint_push_clip_glyph([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_push_clip_rectangle", ExactSpelling = true)]
        public static extern void paint_push_clip_rectangle([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, float xmin, float ymin, float xmax, float ymax);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_pop_clip", ExactSpelling = true)]
        public static extern void paint_pop_clip([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_color", ExactSpelling = true)]
        public static extern void paint_color([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, [NativeTypeName("hb_bool_t")] int is_foreground, [NativeTypeName("hb_color_t")] uint color);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_image", ExactSpelling = true)]
        public static extern void paint_image([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, [NativeTypeName("hb_blob_t*")] nint image, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("hb_tag_t")] uint format, float slant, hb_glyph_extents_t* extents);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_linear_gradient", ExactSpelling = true)]
        public static extern void paint_linear_gradient([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, hb_color_line_t* color_line, float x0, float y0, float x1, float y1, float x2, float y2);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_radial_gradient", ExactSpelling = true)]
        public static extern void paint_radial_gradient([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, hb_color_line_t* color_line, float x0, float y0, float r0, float x1, float y1, float r1);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_sweep_gradient", ExactSpelling = true)]
        public static extern void paint_sweep_gradient([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, hb_color_line_t* color_line, float x0, float y0, float start_angle, float end_angle);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_push_group", ExactSpelling = true)]
        public static extern void paint_push_group([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_pop_group", ExactSpelling = true)]
        public static extern void paint_pop_group([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, hb_paint_composite_mode_t mode);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_paint_custom_palette_color", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int paint_custom_palette_color([NativeTypeName("hb_paint_funcs_t*")] nint funcs, void* paint_data, [NativeTypeName("unsigned int")] uint color_index, [NativeTypeName("hb_color_t *")] uint* color);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_font_funcs_t*")]
        public static extern nint font_funcs_create();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_font_funcs_t*")]
        public static extern nint font_funcs_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_font_funcs_t*")]
        public static extern nint font_funcs_reference([NativeTypeName("hb_font_funcs_t*")] nint ffuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_destroy", ExactSpelling = true)]
        public static extern void font_funcs_destroy([NativeTypeName("hb_font_funcs_t*")] nint ffuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_funcs_set_user_data([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_get_user_data", ExactSpelling = true)]
        public static extern void* font_funcs_get_user_data([NativeTypeName("const hb_font_funcs_t *")] nint ffuncs, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_make_immutable", ExactSpelling = true)]
        public static extern void font_funcs_make_immutable([NativeTypeName("hb_font_funcs_t*")] nint ffuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_is_immutable", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_funcs_is_immutable([NativeTypeName("hb_font_funcs_t*")] nint ffuncs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_font_h_extents_func", ExactSpelling = true)]
        public static extern void font_funcs_set_font_h_extents_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_font_h_extents_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_font_extents_t*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_font_v_extents_func", ExactSpelling = true)]
        public static extern void font_funcs_set_font_v_extents_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_font_v_extents_func_t")] delegate* unmanaged[Cdecl]<nint, void*, hb_font_extents_t*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_nominal_glyph_func", ExactSpelling = true)]
        public static extern void font_funcs_set_nominal_glyph_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_nominal_glyph_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_nominal_glyphs_func", ExactSpelling = true)]
        public static extern void font_funcs_set_nominal_glyphs_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_nominal_glyphs_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint*, uint, uint*, uint, void*, uint> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_variation_glyph_func", ExactSpelling = true)]
        public static extern void font_funcs_set_variation_glyph_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_variation_glyph_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint, uint*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_h_advance_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_h_advance_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_h_advance_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_v_advance_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_v_advance_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_v_advance_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_h_advances_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_h_advances_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_h_advances_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint*, uint, int*, uint, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_v_advances_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_v_advances_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_v_advances_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint*, uint, int*, uint, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_h_origin_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_h_origin_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_h_origin_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, int*, int*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_v_origin_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_v_origin_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_v_origin_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, int*, int*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_h_origins_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_h_origins_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_h_origins_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint*, uint, int*, uint, int*, uint, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_v_origins_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_v_origins_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_v_origins_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint*, uint, int*, uint, int*, uint, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_h_kerning_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_h_kerning_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_h_kerning_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_extents_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_extents_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_extents_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, hb_glyph_extents_t*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_contour_point_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_contour_point_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_contour_point_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint, int*, int*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_name_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_name_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_name_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, byte*, uint, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_from_name_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_from_name_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_from_name_func_t")] delegate* unmanaged[Cdecl]<nint, void*, byte*, int, uint*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_draw_glyph_or_fail_func", ExactSpelling = true)]
        public static extern void font_funcs_set_draw_glyph_or_fail_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_draw_glyph_or_fail_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, nint, void*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_paint_glyph_or_fail_func", ExactSpelling = true)]
        public static extern void font_funcs_set_paint_glyph_or_fail_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_paint_glyph_or_fail_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, nint, void*, uint, uint, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_h_extents", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_h_extents([NativeTypeName("hb_font_t*")] nint font, hb_font_extents_t* extents);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_v_extents", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_v_extents([NativeTypeName("hb_font_t*")] nint font, hb_font_extents_t* extents);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_nominal_glyph", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_nominal_glyph([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint unicode, [NativeTypeName("hb_codepoint_t *")] uint* glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_variation_glyph", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_variation_glyph([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint unicode, [NativeTypeName("hb_codepoint_t")] uint variation_selector, [NativeTypeName("hb_codepoint_t *")] uint* glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_nominal_glyphs", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint font_get_nominal_glyphs([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int")] uint count, [NativeTypeName("const hb_codepoint_t *")] uint* first_unicode, [NativeTypeName("unsigned int")] uint unicode_stride, [NativeTypeName("hb_codepoint_t *")] uint* first_glyph, [NativeTypeName("unsigned int")] uint glyph_stride);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_h_advance", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int font_get_glyph_h_advance([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_v_advance", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int font_get_glyph_v_advance([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_h_advances", ExactSpelling = true)]
        public static extern void font_get_glyph_h_advances([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int")] uint count, [NativeTypeName("const hb_codepoint_t *")] uint* first_glyph, [NativeTypeName("unsigned int")] uint glyph_stride, [NativeTypeName("hb_position_t *")] int* first_advance, [NativeTypeName("unsigned int")] uint advance_stride);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_v_advances", ExactSpelling = true)]
        public static extern void font_get_glyph_v_advances([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int")] uint count, [NativeTypeName("const hb_codepoint_t *")] uint* first_glyph, [NativeTypeName("unsigned int")] uint glyph_stride, [NativeTypeName("hb_position_t *")] int* first_advance, [NativeTypeName("unsigned int")] uint advance_stride);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_h_origin", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph_h_origin([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("hb_position_t *")] int* x, [NativeTypeName("hb_position_t *")] int* y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_v_origin", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph_v_origin([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("hb_position_t *")] int* x, [NativeTypeName("hb_position_t *")] int* y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_h_origins", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph_h_origins([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int")] uint count, [NativeTypeName("const hb_codepoint_t *")] uint* first_glyph, [NativeTypeName("unsigned int")] uint glyph_stride, [NativeTypeName("hb_position_t *")] int* first_x, [NativeTypeName("unsigned int")] uint x_stride, [NativeTypeName("hb_position_t *")] int* first_y, [NativeTypeName("unsigned int")] uint y_stride);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_v_origins", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph_v_origins([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int")] uint count, [NativeTypeName("const hb_codepoint_t *")] uint* first_glyph, [NativeTypeName("unsigned int")] uint glyph_stride, [NativeTypeName("hb_position_t *")] int* first_x, [NativeTypeName("unsigned int")] uint x_stride, [NativeTypeName("hb_position_t *")] int* first_y, [NativeTypeName("unsigned int")] uint y_stride);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_h_kerning", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int font_get_glyph_h_kerning([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint left_glyph, [NativeTypeName("hb_codepoint_t")] uint right_glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_extents", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph_extents([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, hb_glyph_extents_t* extents);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_contour_point", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph_contour_point([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("unsigned int")] uint point_index, [NativeTypeName("hb_position_t *")] int* x, [NativeTypeName("hb_position_t *")] int* y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_name", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph_name([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("char *")] byte* name, [NativeTypeName("unsigned int")] uint size);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_from_name", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph_from_name([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("const char *")] byte* name, int len, [NativeTypeName("hb_codepoint_t *")] uint* glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_draw_glyph_or_fail", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_draw_glyph_or_fail([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, void* draw_data);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_paint_glyph_or_fail", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_paint_glyph_or_fail([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("hb_paint_funcs_t*")] nint pfuncs, void* paint_data, [NativeTypeName("unsigned int")] uint palette_index, [NativeTypeName("hb_color_t")] uint foreground);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint unicode, [NativeTypeName("hb_codepoint_t")] uint variation_selector, [NativeTypeName("hb_codepoint_t *")] uint* glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_extents_for_direction", ExactSpelling = true)]
        public static extern void font_get_extents_for_direction([NativeTypeName("hb_font_t*")] nint font, hb_direction_t direction, hb_font_extents_t* extents);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_advance_for_direction", ExactSpelling = true)]
        public static extern void font_get_glyph_advance_for_direction([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, hb_direction_t direction, [NativeTypeName("hb_position_t *")] int* x, [NativeTypeName("hb_position_t *")] int* y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_advances_for_direction", ExactSpelling = true)]
        public static extern void font_get_glyph_advances_for_direction([NativeTypeName("hb_font_t*")] nint font, hb_direction_t direction, [NativeTypeName("unsigned int")] uint count, [NativeTypeName("const hb_codepoint_t *")] uint* first_glyph, [NativeTypeName("unsigned int")] uint glyph_stride, [NativeTypeName("hb_position_t *")] int* first_advance, [NativeTypeName("unsigned int")] uint advance_stride);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_origin_for_direction", ExactSpelling = true)]
        public static extern void font_get_glyph_origin_for_direction([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, hb_direction_t direction, [NativeTypeName("hb_position_t *")] int* x, [NativeTypeName("hb_position_t *")] int* y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_add_glyph_origin_for_direction", ExactSpelling = true)]
        public static extern void font_add_glyph_origin_for_direction([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, hb_direction_t direction, [NativeTypeName("hb_position_t *")] int* x, [NativeTypeName("hb_position_t *")] int* y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_subtract_glyph_origin_for_direction", ExactSpelling = true)]
        public static extern void font_subtract_glyph_origin_for_direction([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, hb_direction_t direction, [NativeTypeName("hb_position_t *")] int* x, [NativeTypeName("hb_position_t *")] int* y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_kerning_for_direction", ExactSpelling = true)]
        public static extern void font_get_glyph_kerning_for_direction([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint first_glyph, [NativeTypeName("hb_codepoint_t")] uint second_glyph, hb_direction_t direction, [NativeTypeName("hb_position_t *")] int* x, [NativeTypeName("hb_position_t *")] int* y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_extents_for_origin", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph_extents_for_origin([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, hb_direction_t direction, hb_glyph_extents_t* extents);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_contour_point_for_origin", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_get_glyph_contour_point_for_origin([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("unsigned int")] uint point_index, hb_direction_t direction, [NativeTypeName("hb_position_t *")] int* x, [NativeTypeName("hb_position_t *")] int* y);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_glyph_to_string", ExactSpelling = true)]
        public static extern void font_glyph_to_string([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("char *")] byte* s, [NativeTypeName("unsigned int")] uint size);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_glyph_from_string", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_glyph_from_string([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("const char *")] byte* s, int len, [NativeTypeName("hb_codepoint_t *")] uint* glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_draw_glyph", ExactSpelling = true)]
        public static extern void font_draw_glyph([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, void* draw_data);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_paint_glyph", ExactSpelling = true)]
        public static extern void font_paint_glyph([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("hb_paint_funcs_t*")] nint pfuncs, void* paint_data, [NativeTypeName("unsigned int")] uint palette_index, [NativeTypeName("hb_color_t")] uint foreground);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_font_t*")]
        public static extern nint font_create([NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_create_sub_font", ExactSpelling = true)]
        [return: NativeTypeName("hb_font_t*")]
        public static extern nint font_create_sub_font([NativeTypeName("hb_font_t*")] nint parent);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_font_t*")]
        public static extern nint font_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_font_t*")]
        public static extern nint font_reference([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_destroy", ExactSpelling = true)]
        public static extern void font_destroy([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_set_user_data([NativeTypeName("hb_font_t*")] nint font, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_user_data", ExactSpelling = true)]
        public static extern void* font_get_user_data([NativeTypeName("const hb_font_t *")] nint font, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_make_immutable", ExactSpelling = true)]
        public static extern void font_make_immutable([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_is_immutable", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_is_immutable([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_serial", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint font_get_serial([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_changed", ExactSpelling = true)]
        public static extern void font_changed([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_parent", ExactSpelling = true)]
        public static extern void font_set_parent([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_font_t*")] nint parent);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_parent", ExactSpelling = true)]
        [return: NativeTypeName("hb_font_t*")]
        public static extern nint font_get_parent([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_face", ExactSpelling = true)]
        public static extern void font_set_face([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_face_t*")] nint face);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_face", ExactSpelling = true)]
        [return: NativeTypeName("hb_face_t*")]
        public static extern nint font_get_face([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_funcs", ExactSpelling = true)]
        public static extern void font_set_funcs([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_font_funcs_t*")] nint klass, void* font_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_funcs_data", ExactSpelling = true)]
        public static extern void font_set_funcs_data([NativeTypeName("hb_font_t*")] nint font, void* font_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_funcs_using", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_set_funcs_using([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("const char *")] byte* name);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_list_funcs", ExactSpelling = true)]
        [return: NativeTypeName("const char **")]
        public static extern byte** font_list_funcs();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_scale", ExactSpelling = true)]
        public static extern void font_set_scale([NativeTypeName("hb_font_t*")] nint font, int x_scale, int y_scale);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_scale", ExactSpelling = true)]
        public static extern void font_get_scale([NativeTypeName("hb_font_t*")] nint font, int* x_scale, int* y_scale);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_ppem", ExactSpelling = true)]
        public static extern void font_set_ppem([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int")] uint x_ppem, [NativeTypeName("unsigned int")] uint y_ppem);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_ppem", ExactSpelling = true)]
        public static extern void font_get_ppem([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int *")] uint* x_ppem, [NativeTypeName("unsigned int *")] uint* y_ppem);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_ptem", ExactSpelling = true)]
        public static extern void font_set_ptem([NativeTypeName("hb_font_t*")] nint font, float ptem);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_ptem", ExactSpelling = true)]
        public static extern float font_get_ptem([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_is_synthetic", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int font_is_synthetic([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_synthetic_bold", ExactSpelling = true)]
        public static extern void font_set_synthetic_bold([NativeTypeName("hb_font_t*")] nint font, float x_embolden, float y_embolden, [NativeTypeName("hb_bool_t")] int in_place);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_synthetic_bold", ExactSpelling = true)]
        public static extern void font_get_synthetic_bold([NativeTypeName("hb_font_t*")] nint font, float* x_embolden, float* y_embolden, [NativeTypeName("hb_bool_t *")] int* in_place);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_synthetic_slant", ExactSpelling = true)]
        public static extern void font_set_synthetic_slant([NativeTypeName("hb_font_t*")] nint font, float slant);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_synthetic_slant", ExactSpelling = true)]
        public static extern float font_get_synthetic_slant([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_variations", ExactSpelling = true)]
        public static extern void font_set_variations([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("const hb_variation_t *")] hb_variation_t* variations, [NativeTypeName("unsigned int")] uint variations_length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_variation", ExactSpelling = true)]
        public static extern void font_set_variation([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_tag_t")] uint tag, float value);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_var_coords_design", ExactSpelling = true)]
        public static extern void font_set_var_coords_design([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("const float *")] float* coords, [NativeTypeName("unsigned int")] uint coords_length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_var_coords_design", ExactSpelling = true)]
        [return: NativeTypeName("const float *")]
        public static extern float* font_get_var_coords_design([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int *")] uint* length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_var_coords_normalized", ExactSpelling = true)]
        public static extern void font_set_var_coords_normalized([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("const int *")] int* coords, [NativeTypeName("unsigned int")] uint coords_length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_var_coords_normalized", ExactSpelling = true)]
        [return: NativeTypeName("const int *")]
        public static extern int* font_get_var_coords_normalized([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int *")] uint* length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_set_var_named_instance", ExactSpelling = true)]
        public static extern void font_set_var_named_instance([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("unsigned int")] uint instance_index);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_var_named_instance", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint font_get_var_named_instance([NativeTypeName("hb_font_t*")] nint font);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_glyph_info_get_glyph_flags", ExactSpelling = true)]
        public static extern hb_glyph_flags_t glyph_info_get_glyph_flags([NativeTypeName("const hb_glyph_info_t *")] hb_glyph_info_t* info);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_segment_properties_equal", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int segment_properties_equal([NativeTypeName("const hb_segment_properties_t *")] hb_segment_properties_t* a, [NativeTypeName("const hb_segment_properties_t *")] hb_segment_properties_t* b);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_segment_properties_hash", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint segment_properties_hash([NativeTypeName("const hb_segment_properties_t *")] hb_segment_properties_t* p);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_segment_properties_overlay", ExactSpelling = true)]
        public static extern void segment_properties_overlay(hb_segment_properties_t* p, [NativeTypeName("const hb_segment_properties_t *")] hb_segment_properties_t* src);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_buffer_t*")]
        public static extern nint buffer_create();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_create_similar", ExactSpelling = true)]
        [return: NativeTypeName("hb_buffer_t*")]
        public static extern nint buffer_create_similar([NativeTypeName("const hb_buffer_t *")] nint src);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_reset", ExactSpelling = true)]
        public static extern void buffer_reset([NativeTypeName("hb_buffer_t*")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_buffer_t*")]
        public static extern nint buffer_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_buffer_t*")]
        public static extern nint buffer_reference([NativeTypeName("hb_buffer_t*")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_destroy", ExactSpelling = true)]
        public static extern void buffer_destroy([NativeTypeName("hb_buffer_t*")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int buffer_set_user_data([NativeTypeName("hb_buffer_t*")] nint buffer, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_user_data", ExactSpelling = true)]
        public static extern void* buffer_get_user_data([NativeTypeName("const hb_buffer_t *")] nint buffer, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_content_type", ExactSpelling = true)]
        public static extern void buffer_set_content_type([NativeTypeName("hb_buffer_t*")] nint buffer, hb_buffer_content_type_t content_type);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_content_type", ExactSpelling = true)]
        public static extern hb_buffer_content_type_t buffer_get_content_type([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_unicode_funcs", ExactSpelling = true)]
        public static extern void buffer_set_unicode_funcs([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("hb_unicode_funcs_t*")] nint unicode_funcs);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_unicode_funcs", ExactSpelling = true)]
        [return: NativeTypeName("hb_unicode_funcs_t*")]
        public static extern nint buffer_get_unicode_funcs([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_direction", ExactSpelling = true)]
        public static extern void buffer_set_direction([NativeTypeName("hb_buffer_t*")] nint buffer, hb_direction_t direction);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_direction", ExactSpelling = true)]
        public static extern hb_direction_t buffer_get_direction([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_script", ExactSpelling = true)]
        public static extern void buffer_set_script([NativeTypeName("hb_buffer_t*")] nint buffer, hb_script_t script);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_script", ExactSpelling = true)]
        public static extern hb_script_t buffer_get_script([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_language", ExactSpelling = true)]
        public static extern void buffer_set_language([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("hb_language_t")] nint language);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_language", ExactSpelling = true)]
        [return: NativeTypeName("hb_language_t")]
        public static extern nint buffer_get_language([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_segment_properties", ExactSpelling = true)]
        public static extern void buffer_set_segment_properties([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const hb_segment_properties_t *")] hb_segment_properties_t* props);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_segment_properties", ExactSpelling = true)]
        public static extern void buffer_get_segment_properties([NativeTypeName("const hb_buffer_t *")] nint buffer, hb_segment_properties_t* props);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_guess_segment_properties", ExactSpelling = true)]
        public static extern void buffer_guess_segment_properties([NativeTypeName("hb_buffer_t*")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_flags", ExactSpelling = true)]
        public static extern void buffer_set_flags([NativeTypeName("hb_buffer_t*")] nint buffer, hb_buffer_flags_t flags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_flags", ExactSpelling = true)]
        public static extern hb_buffer_flags_t buffer_get_flags([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_cluster_level", ExactSpelling = true)]
        public static extern void buffer_set_cluster_level([NativeTypeName("hb_buffer_t*")] nint buffer, hb_buffer_cluster_level_t cluster_level);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_cluster_level", ExactSpelling = true)]
        public static extern hb_buffer_cluster_level_t buffer_get_cluster_level([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_replacement_codepoint", ExactSpelling = true)]
        public static extern void buffer_set_replacement_codepoint([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("hb_codepoint_t")] uint replacement);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_replacement_codepoint", ExactSpelling = true)]
        [return: NativeTypeName("hb_codepoint_t")]
        public static extern uint buffer_get_replacement_codepoint([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_invisible_glyph", ExactSpelling = true)]
        public static extern void buffer_set_invisible_glyph([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("hb_codepoint_t")] uint invisible);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_invisible_glyph", ExactSpelling = true)]
        [return: NativeTypeName("hb_codepoint_t")]
        public static extern uint buffer_get_invisible_glyph([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_not_found_glyph", ExactSpelling = true)]
        public static extern void buffer_set_not_found_glyph([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("hb_codepoint_t")] uint not_found);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_not_found_glyph", ExactSpelling = true)]
        [return: NativeTypeName("hb_codepoint_t")]
        public static extern uint buffer_get_not_found_glyph([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_not_found_variation_selector_glyph", ExactSpelling = true)]
        public static extern void buffer_set_not_found_variation_selector_glyph([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("hb_codepoint_t")] uint not_found_variation_selector);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_not_found_variation_selector_glyph", ExactSpelling = true)]
        [return: NativeTypeName("hb_codepoint_t")]
        public static extern uint buffer_get_not_found_variation_selector_glyph([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_random_state", ExactSpelling = true)]
        public static extern void buffer_set_random_state([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("unsigned int")] uint state);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_random_state", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint buffer_get_random_state([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_clear_contents", ExactSpelling = true)]
        public static extern void buffer_clear_contents([NativeTypeName("hb_buffer_t*")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_pre_allocate", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int buffer_pre_allocate([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("unsigned int")] uint size);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_allocation_successful", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int buffer_allocation_successful([NativeTypeName("hb_buffer_t*")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_reverse", ExactSpelling = true)]
        public static extern void buffer_reverse([NativeTypeName("hb_buffer_t*")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_reverse_range", ExactSpelling = true)]
        public static extern void buffer_reverse_range([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("unsigned int")] uint start, [NativeTypeName("unsigned int")] uint end);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_reverse_clusters", ExactSpelling = true)]
        public static extern void buffer_reverse_clusters([NativeTypeName("hb_buffer_t*")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_add", ExactSpelling = true)]
        public static extern void buffer_add([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("hb_codepoint_t")] uint codepoint, [NativeTypeName("unsigned int")] uint cluster);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_add_utf8", ExactSpelling = true)]
        public static extern void buffer_add_utf8([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const char *")] byte* text, int text_length, [NativeTypeName("unsigned int")] uint item_offset, int item_length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_add_utf16", ExactSpelling = true)]
        public static extern void buffer_add_utf16([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const uint16_t *")] ushort* text, int text_length, [NativeTypeName("unsigned int")] uint item_offset, int item_length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_add_utf32", ExactSpelling = true)]
        public static extern void buffer_add_utf32([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const uint32_t *")] uint* text, int text_length, [NativeTypeName("unsigned int")] uint item_offset, int item_length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_add_latin1", ExactSpelling = true)]
        public static extern void buffer_add_latin1([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const uint8_t *")] byte* text, int text_length, [NativeTypeName("unsigned int")] uint item_offset, int item_length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_add_codepoints", ExactSpelling = true)]
        public static extern void buffer_add_codepoints([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const hb_codepoint_t *")] uint* text, int text_length, [NativeTypeName("unsigned int")] uint item_offset, int item_length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_append", ExactSpelling = true)]
        public static extern void buffer_append([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const hb_buffer_t *")] nint source, [NativeTypeName("unsigned int")] uint start, [NativeTypeName("unsigned int")] uint end);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_length", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int buffer_set_length([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("unsigned int")] uint length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_length", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint buffer_get_length([NativeTypeName("const hb_buffer_t *")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_glyph_infos", ExactSpelling = true)]
        public static extern hb_glyph_info_t* buffer_get_glyph_infos([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("unsigned int *")] uint* length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_get_glyph_positions", ExactSpelling = true)]
        public static extern hb_glyph_position_t* buffer_get_glyph_positions([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("unsigned int *")] uint* length);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_has_positions", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int buffer_has_positions([NativeTypeName("hb_buffer_t*")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_normalize_glyphs", ExactSpelling = true)]
        public static extern void buffer_normalize_glyphs([NativeTypeName("hb_buffer_t*")] nint buffer);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_serialize_format_from_string", ExactSpelling = true)]
        public static extern hb_buffer_serialize_format_t buffer_serialize_format_from_string([NativeTypeName("const char *")] byte* str, int len);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_serialize_format_to_string", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* buffer_serialize_format_to_string(hb_buffer_serialize_format_t format);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_serialize_list_formats", ExactSpelling = true)]
        [return: NativeTypeName("const char **")]
        public static extern byte** buffer_serialize_list_formats();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_serialize_glyphs", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint buffer_serialize_glyphs([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("unsigned int")] uint start, [NativeTypeName("unsigned int")] uint end, [NativeTypeName("char *")] byte* buf, [NativeTypeName("unsigned int")] uint buf_size, [NativeTypeName("unsigned int *")] uint* buf_consumed, [NativeTypeName("hb_font_t*")] nint font, hb_buffer_serialize_format_t format, hb_buffer_serialize_flags_t flags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_serialize_unicode", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint buffer_serialize_unicode([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("unsigned int")] uint start, [NativeTypeName("unsigned int")] uint end, [NativeTypeName("char *")] byte* buf, [NativeTypeName("unsigned int")] uint buf_size, [NativeTypeName("unsigned int *")] uint* buf_consumed, hb_buffer_serialize_format_t format, hb_buffer_serialize_flags_t flags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_serialize", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint buffer_serialize([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("unsigned int")] uint start, [NativeTypeName("unsigned int")] uint end, [NativeTypeName("char *")] byte* buf, [NativeTypeName("unsigned int")] uint buf_size, [NativeTypeName("unsigned int *")] uint* buf_consumed, [NativeTypeName("hb_font_t*")] nint font, hb_buffer_serialize_format_t format, hb_buffer_serialize_flags_t flags);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_deserialize_glyphs", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int buffer_deserialize_glyphs([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const char *")] byte* buf, int buf_len, [NativeTypeName("const char **")] byte** end_ptr, [NativeTypeName("hb_font_t*")] nint font, hb_buffer_serialize_format_t format);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_deserialize_unicode", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int buffer_deserialize_unicode([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const char *")] byte* buf, int buf_len, [NativeTypeName("const char **")] byte** end_ptr, hb_buffer_serialize_format_t format);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_diff", ExactSpelling = true)]
        public static extern hb_buffer_diff_flags_t buffer_diff([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("hb_buffer_t*")] nint reference, [NativeTypeName("hb_codepoint_t")] uint dottedcircle_glyph, [NativeTypeName("unsigned int")] uint position_fuzz);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_buffer_set_message_func", ExactSpelling = true)]
        public static extern void buffer_set_message_func([NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("hb_buffer_message_func_t")] delegate* unmanaged[Cdecl]<nint, nint, byte*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_func", ExactSpelling = true)]
        [Obsolete]
        public static extern void font_funcs_set_glyph_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint, uint*, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_set_eastasian_width_func", ExactSpelling = true)]
        [Obsolete]
        public static extern void unicode_funcs_set_eastasian_width_func([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_unicode_eastasian_width_func_t")] delegate* unmanaged[Cdecl]<nint, uint, void*, uint> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_eastasian_width", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        [Obsolete]
        public static extern uint unicode_eastasian_width([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_codepoint_t")] uint unicode);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_funcs_set_decompose_compatibility_func", ExactSpelling = true)]
        [Obsolete]
        public static extern void unicode_funcs_set_decompose_compatibility_func([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_unicode_decompose_compatibility_func_t")] delegate* unmanaged[Cdecl]<nint, uint, uint*, void*, uint> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_unicode_decompose_compatibility", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        [Obsolete]
        public static extern uint unicode_decompose_compatibility([NativeTypeName("hb_unicode_funcs_t*")] nint ufuncs, [NativeTypeName("hb_codepoint_t")] uint u, [NativeTypeName("hb_codepoint_t *")] uint* decomposed);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_v_kerning_func", ExactSpelling = true)]
        public static extern void font_funcs_set_glyph_v_kerning_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_v_kerning_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, uint, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_v_kerning", ExactSpelling = true)]
        [return: NativeTypeName("hb_position_t")]
        public static extern int font_get_glyph_v_kerning([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint top_glyph, [NativeTypeName("hb_codepoint_t")] uint bottom_glyph);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_glyph_shape_func", ExactSpelling = true)]
        [Obsolete]
        public static extern void font_funcs_set_glyph_shape_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_get_glyph_shape_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, nint, void*, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_draw_glyph_func", ExactSpelling = true)]
        [Obsolete]
        public static extern void font_funcs_set_draw_glyph_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_draw_glyph_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, nint, void*, void*, void> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_funcs_set_paint_glyph_func", ExactSpelling = true)]
        [Obsolete]
        public static extern void font_funcs_set_paint_glyph_func([NativeTypeName("hb_font_funcs_t*")] nint ffuncs, [NativeTypeName("hb_font_paint_glyph_func_t")] delegate* unmanaged[Cdecl]<nint, void*, uint, nint, void*, uint, uint, void*, int> func, void* user_data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_font_get_glyph_shape", ExactSpelling = true)]
        [Obsolete]
        public static extern void font_get_glyph_shape([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_codepoint_t")] uint glyph, [NativeTypeName("hb_draw_funcs_t*")] nint dfuncs, void* draw_data);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape", ExactSpelling = true)]
        public static extern void shape([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const hb_feature_t *")] hb_feature_t* features, [NativeTypeName("unsigned int")] uint num_features);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_full", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int shape_full([NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const hb_feature_t *")] hb_feature_t* features, [NativeTypeName("unsigned int")] uint num_features, [NativeTypeName("const char *const *")] byte** shaper_list);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_list_shapers", ExactSpelling = true)]
        [return: NativeTypeName("const char **")]
        public static extern byte** shape_list_shapers();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_create", ExactSpelling = true)]
        [return: NativeTypeName("hb_shape_plan_t*")]
        public static extern nint shape_plan_create([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("const hb_segment_properties_t *")] hb_segment_properties_t* props, [NativeTypeName("const hb_feature_t *")] hb_feature_t* user_features, [NativeTypeName("unsigned int")] uint num_user_features, [NativeTypeName("const char *const *")] byte** shaper_list);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_create_cached", ExactSpelling = true)]
        [return: NativeTypeName("hb_shape_plan_t*")]
        public static extern nint shape_plan_create_cached([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("const hb_segment_properties_t *")] hb_segment_properties_t* props, [NativeTypeName("const hb_feature_t *")] hb_feature_t* user_features, [NativeTypeName("unsigned int")] uint num_user_features, [NativeTypeName("const char *const *")] byte** shaper_list);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_create2", ExactSpelling = true)]
        [return: NativeTypeName("hb_shape_plan_t*")]
        public static extern nint shape_plan_create2([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("const hb_segment_properties_t *")] hb_segment_properties_t* props, [NativeTypeName("const hb_feature_t *")] hb_feature_t* user_features, [NativeTypeName("unsigned int")] uint num_user_features, [NativeTypeName("const int *")] int* coords, [NativeTypeName("unsigned int")] uint num_coords, [NativeTypeName("const char *const *")] byte** shaper_list);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_create_cached2", ExactSpelling = true)]
        [return: NativeTypeName("hb_shape_plan_t*")]
        public static extern nint shape_plan_create_cached2([NativeTypeName("hb_face_t*")] nint face, [NativeTypeName("const hb_segment_properties_t *")] hb_segment_properties_t* props, [NativeTypeName("const hb_feature_t *")] hb_feature_t* user_features, [NativeTypeName("unsigned int")] uint num_user_features, [NativeTypeName("const int *")] int* coords, [NativeTypeName("unsigned int")] uint num_coords, [NativeTypeName("const char *const *")] byte** shaper_list);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_get_empty", ExactSpelling = true)]
        [return: NativeTypeName("hb_shape_plan_t*")]
        public static extern nint shape_plan_get_empty();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_reference", ExactSpelling = true)]
        [return: NativeTypeName("hb_shape_plan_t*")]
        public static extern nint shape_plan_reference([NativeTypeName("hb_shape_plan_t*")] nint shape_plan);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_destroy", ExactSpelling = true)]
        public static extern void shape_plan_destroy([NativeTypeName("hb_shape_plan_t*")] nint shape_plan);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_set_user_data", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int shape_plan_set_user_data([NativeTypeName("hb_shape_plan_t*")] nint shape_plan, hb_user_data_key_t* key, void* data, [NativeTypeName("hb_destroy_func_t")] delegate* unmanaged[Cdecl]<void*, void> destroy, [NativeTypeName("hb_bool_t")] int replace);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_get_user_data", ExactSpelling = true)]
        public static extern void* shape_plan_get_user_data([NativeTypeName("const hb_shape_plan_t *")] nint shape_plan, hb_user_data_key_t* key);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_execute", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int shape_plan_execute([NativeTypeName("hb_shape_plan_t*")] nint shape_plan, [NativeTypeName("hb_font_t*")] nint font, [NativeTypeName("hb_buffer_t*")] nint buffer, [NativeTypeName("const hb_feature_t *")] hb_feature_t* features, [NativeTypeName("unsigned int")] uint num_features);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_shape_plan_get_shaper", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* shape_plan_get_shaper([NativeTypeName("hb_shape_plan_t*")] nint shape_plan);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_style_get_value", ExactSpelling = true)]
        public static extern float style_get_value([NativeTypeName("hb_font_t*")] nint font, hb_style_tag_t style_tag);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_version", ExactSpelling = true)]
        public static extern void version([NativeTypeName("unsigned int *")] uint* major, [NativeTypeName("unsigned int *")] uint* minor, [NativeTypeName("unsigned int *")] uint* micro);

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_version_string", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* version_string();

        [DllImport("harfbuzz", CallingConvention = CallingConvention.Cdecl, EntryPoint = "hb_version_atleast", ExactSpelling = true)]
        [return: NativeTypeName("hb_bool_t")]
        public static extern int version_atleast([NativeTypeName("unsigned int")] uint major, [NativeTypeName("unsigned int")] uint minor, [NativeTypeName("unsigned int")] uint micro);
    }
}
