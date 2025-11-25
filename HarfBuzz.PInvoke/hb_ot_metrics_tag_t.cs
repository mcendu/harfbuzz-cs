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
    public enum hb_ot_metrics_tag_t : uint
    {
        HB_OT_METRICS_TAG_HORIZONTAL_ASCENDER = ((uint)((((uint)('h') & 0xFF) << 24) | (((uint)('a') & 0xFF) << 16) | (((uint)('s') & 0xFF) << 8) | ((uint)('c') & 0xFF))),
        HB_OT_METRICS_TAG_HORIZONTAL_DESCENDER = ((uint)((((uint)('h') & 0xFF) << 24) | (((uint)('d') & 0xFF) << 16) | (((uint)('s') & 0xFF) << 8) | ((uint)('c') & 0xFF))),
        HB_OT_METRICS_TAG_HORIZONTAL_LINE_GAP = ((uint)((((uint)('h') & 0xFF) << 24) | (((uint)('l') & 0xFF) << 16) | (((uint)('g') & 0xFF) << 8) | ((uint)('p') & 0xFF))),
        HB_OT_METRICS_TAG_HORIZONTAL_CLIPPING_ASCENT = ((uint)((((uint)('h') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('l') & 0xFF) << 8) | ((uint)('a') & 0xFF))),
        HB_OT_METRICS_TAG_HORIZONTAL_CLIPPING_DESCENT = ((uint)((((uint)('h') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('l') & 0xFF) << 8) | ((uint)('d') & 0xFF))),
        HB_OT_METRICS_TAG_VERTICAL_ASCENDER = ((uint)((((uint)('v') & 0xFF) << 24) | (((uint)('a') & 0xFF) << 16) | (((uint)('s') & 0xFF) << 8) | ((uint)('c') & 0xFF))),
        HB_OT_METRICS_TAG_VERTICAL_DESCENDER = ((uint)((((uint)('v') & 0xFF) << 24) | (((uint)('d') & 0xFF) << 16) | (((uint)('s') & 0xFF) << 8) | ((uint)('c') & 0xFF))),
        HB_OT_METRICS_TAG_VERTICAL_LINE_GAP = ((uint)((((uint)('v') & 0xFF) << 24) | (((uint)('l') & 0xFF) << 16) | (((uint)('g') & 0xFF) << 8) | ((uint)('p') & 0xFF))),
        HB_OT_METRICS_TAG_HORIZONTAL_CARET_RISE = ((uint)((((uint)('h') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('r') & 0xFF) << 8) | ((uint)('s') & 0xFF))),
        HB_OT_METRICS_TAG_HORIZONTAL_CARET_RUN = ((uint)((((uint)('h') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('r') & 0xFF) << 8) | ((uint)('n') & 0xFF))),
        HB_OT_METRICS_TAG_HORIZONTAL_CARET_OFFSET = ((uint)((((uint)('h') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('o') & 0xFF) << 8) | ((uint)('f') & 0xFF))),
        HB_OT_METRICS_TAG_VERTICAL_CARET_RISE = ((uint)((((uint)('v') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('r') & 0xFF) << 8) | ((uint)('s') & 0xFF))),
        HB_OT_METRICS_TAG_VERTICAL_CARET_RUN = ((uint)((((uint)('v') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('r') & 0xFF) << 8) | ((uint)('n') & 0xFF))),
        HB_OT_METRICS_TAG_VERTICAL_CARET_OFFSET = ((uint)((((uint)('v') & 0xFF) << 24) | (((uint)('c') & 0xFF) << 16) | (((uint)('o') & 0xFF) << 8) | ((uint)('f') & 0xFF))),
        HB_OT_METRICS_TAG_X_HEIGHT = ((uint)((((uint)('x') & 0xFF) << 24) | (((uint)('h') & 0xFF) << 16) | (((uint)('g') & 0xFF) << 8) | ((uint)('t') & 0xFF))),
        HB_OT_METRICS_TAG_CAP_HEIGHT = ((uint)((((uint)('c') & 0xFF) << 24) | (((uint)('p') & 0xFF) << 16) | (((uint)('h') & 0xFF) << 8) | ((uint)('t') & 0xFF))),
        HB_OT_METRICS_TAG_SUBSCRIPT_EM_X_SIZE = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('b') & 0xFF) << 16) | (((uint)('x') & 0xFF) << 8) | ((uint)('s') & 0xFF))),
        HB_OT_METRICS_TAG_SUBSCRIPT_EM_Y_SIZE = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('b') & 0xFF) << 16) | (((uint)('y') & 0xFF) << 8) | ((uint)('s') & 0xFF))),
        HB_OT_METRICS_TAG_SUBSCRIPT_EM_X_OFFSET = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('b') & 0xFF) << 16) | (((uint)('x') & 0xFF) << 8) | ((uint)('o') & 0xFF))),
        HB_OT_METRICS_TAG_SUBSCRIPT_EM_Y_OFFSET = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('b') & 0xFF) << 16) | (((uint)('y') & 0xFF) << 8) | ((uint)('o') & 0xFF))),
        HB_OT_METRICS_TAG_SUPERSCRIPT_EM_X_SIZE = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('p') & 0xFF) << 16) | (((uint)('x') & 0xFF) << 8) | ((uint)('s') & 0xFF))),
        HB_OT_METRICS_TAG_SUPERSCRIPT_EM_Y_SIZE = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('p') & 0xFF) << 16) | (((uint)('y') & 0xFF) << 8) | ((uint)('s') & 0xFF))),
        HB_OT_METRICS_TAG_SUPERSCRIPT_EM_X_OFFSET = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('p') & 0xFF) << 16) | (((uint)('x') & 0xFF) << 8) | ((uint)('o') & 0xFF))),
        HB_OT_METRICS_TAG_SUPERSCRIPT_EM_Y_OFFSET = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('p') & 0xFF) << 16) | (((uint)('y') & 0xFF) << 8) | ((uint)('o') & 0xFF))),
        HB_OT_METRICS_TAG_STRIKEOUT_SIZE = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('t') & 0xFF) << 16) | (((uint)('r') & 0xFF) << 8) | ((uint)('s') & 0xFF))),
        HB_OT_METRICS_TAG_STRIKEOUT_OFFSET = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('t') & 0xFF) << 16) | (((uint)('r') & 0xFF) << 8) | ((uint)('o') & 0xFF))),
        HB_OT_METRICS_TAG_UNDERLINE_SIZE = ((uint)((((uint)('u') & 0xFF) << 24) | (((uint)('n') & 0xFF) << 16) | (((uint)('d') & 0xFF) << 8) | ((uint)('s') & 0xFF))),
        HB_OT_METRICS_TAG_UNDERLINE_OFFSET = ((uint)((((uint)('u') & 0xFF) << 24) | (((uint)('n') & 0xFF) << 16) | (((uint)('d') & 0xFF) << 8) | ((uint)('o') & 0xFF))),
        _HB_OT_METRICS_TAG_MAX_VALUE = ((uint)((((uint)(0x7f) & 0xFF) << 24) | (((uint)(0xff) & 0xFF) << 16) | (((uint)(0xff) & 0xFF) << 8) | ((uint)(0xff) & 0xFF))),
    }
}
