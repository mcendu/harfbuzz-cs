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
    public enum hb_style_tag_t : uint
    {
        HB_STYLE_TAG_ITALIC = ((uint)((((uint)('i') & 0xFF) << 24) | (((uint)('t') & 0xFF) << 16) | (((uint)('a') & 0xFF) << 8) | ((uint)('l') & 0xFF))),
        HB_STYLE_TAG_OPTICAL_SIZE = ((uint)((((uint)('o') & 0xFF) << 24) | (((uint)('p') & 0xFF) << 16) | (((uint)('s') & 0xFF) << 8) | ((uint)('z') & 0xFF))),
        HB_STYLE_TAG_SLANT_ANGLE = ((uint)((((uint)('s') & 0xFF) << 24) | (((uint)('l') & 0xFF) << 16) | (((uint)('n') & 0xFF) << 8) | ((uint)('t') & 0xFF))),
        HB_STYLE_TAG_SLANT_RATIO = ((uint)((((uint)('S') & 0xFF) << 24) | (((uint)('l') & 0xFF) << 16) | (((uint)('n') & 0xFF) << 8) | ((uint)('t') & 0xFF))),
        HB_STYLE_TAG_WIDTH = ((uint)((((uint)('w') & 0xFF) << 24) | (((uint)('d') & 0xFF) << 16) | (((uint)('t') & 0xFF) << 8) | ((uint)('h') & 0xFF))),
        HB_STYLE_TAG_WEIGHT = ((uint)((((uint)('w') & 0xFF) << 24) | (((uint)('g') & 0xFF) << 16) | (((uint)('h') & 0xFF) << 8) | ((uint)('t') & 0xFF))),
        _HB_STYLE_TAG_MAX_VALUE = ((uint)((((uint)(0x7f) & 0xFF) << 24) | (((uint)(0xff) & 0xFF) << 16) | (((uint)(0xff) & 0xFF) << 8) | ((uint)(0xff) & 0xFF))),
    }
}
