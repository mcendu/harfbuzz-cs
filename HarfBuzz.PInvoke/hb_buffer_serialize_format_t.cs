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
    public enum hb_buffer_serialize_format_t : uint
    {
        HB_BUFFER_SERIALIZE_FORMAT_TEXT = ((uint)((((uint)('T') & 0xFF) << 24) | (((uint)('E') & 0xFF) << 16) | (((uint)('X') & 0xFF) << 8) | ((uint)('T') & 0xFF))),
        HB_BUFFER_SERIALIZE_FORMAT_JSON = ((uint)((((uint)('J') & 0xFF) << 24) | (((uint)('S') & 0xFF) << 16) | (((uint)('O') & 0xFF) << 8) | ((uint)('N') & 0xFF))),
        HB_BUFFER_SERIALIZE_FORMAT_INVALID = ((uint)((((uint)(0) & 0xFF) << 24) | (((uint)(0) & 0xFF) << 16) | (((uint)(0) & 0xFF) << 8) | ((uint)(0) & 0xFF))),
    }
}
