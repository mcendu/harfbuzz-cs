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
    [NativeTypeName("unsigned int")]
    public enum hb_ot_layout_baseline_tag_t : uint
    {
        HB_OT_LAYOUT_BASELINE_TAG_ROMAN = ((uint)((((uint)('r') & 0xFF) << 24) | (((uint)('o') & 0xFF) << 16) | (((uint)('m') & 0xFF) << 8) | ((uint)('n') & 0xFF))),
        HB_OT_LAYOUT_BASELINE_TAG_HANGING = ((uint)((((uint)('h') & 0xFF) << 24) | (((uint)('a') & 0xFF) << 16) | (((uint)('n') & 0xFF) << 8) | ((uint)('g') & 0xFF))),
        HB_OT_LAYOUT_BASELINE_TAG_IDEO_FACE_BOTTOM_OR_LEFT = ((uint)((((uint)('i') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('f') & 0xFF) << 8) | ((uint)('b') & 0xFF))),
        HB_OT_LAYOUT_BASELINE_TAG_IDEO_FACE_TOP_OR_RIGHT = ((uint)((((uint)('i') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('f') & 0xFF) << 8) | ((uint)('t') & 0xFF))),
        HB_OT_LAYOUT_BASELINE_TAG_IDEO_FACE_CENTRAL = ((uint)((((uint)('I') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('f') & 0xFF) << 8) | ((uint)('c') & 0xFF))),
        HB_OT_LAYOUT_BASELINE_TAG_IDEO_EMBOX_BOTTOM_OR_LEFT = ((uint)((((uint)('i') & 0xFF) << 24) | (((uint)('d') & 0xFF) << 16) | (((uint)('e') & 0xFF) << 8) | ((uint)('o') & 0xFF))),
        HB_OT_LAYOUT_BASELINE_TAG_IDEO_EMBOX_TOP_OR_RIGHT = ((uint)((((uint)('i') & 0xFF) << 24) | (((uint)('d') & 0xFF) << 16) | (((uint)('t') & 0xFF) << 8) | ((uint)('p') & 0xFF))),
        HB_OT_LAYOUT_BASELINE_TAG_IDEO_EMBOX_CENTRAL = ((uint)((((uint)('I') & 0xFF) << 24) | (((uint)('d') & 0xFF) << 16) | (((uint)('c') & 0xFF) << 8) | ((uint)('e') & 0xFF))),
        HB_OT_LAYOUT_BASELINE_TAG_MATH = ((uint)((((uint)('m') & 0xFF) << 24) | (((uint)('a') & 0xFF) << 16) | (((uint)('t') & 0xFF) << 8) | ((uint)('h') & 0xFF))),
        _HB_OT_LAYOUT_BASELINE_TAG_MAX_VALUE = ((uint)((((uint)(0x7f) & 0xFF) << 24) | (((uint)(0xff) & 0xFF) << 16) | (((uint)(0xff) & 0xFF) << 8) | ((uint)(0xff) & 0xFF))),
    }
}
