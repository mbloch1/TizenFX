/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class PlaceContact
    {
        [DllImport(Libraries.MapService, EntryPoint = "maps_place_contact_destroy")]
        internal static extern ErrorCode Destroy(IntPtr /* maps_place_contact_h */ contact);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_contact_clone")]
        internal static extern ErrorCode Clone(PlaceContactHandle /* maps_place_contact_h */ origin, out IntPtr /* maps_place_contact_h */ cloned);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_contact_get_label")]
        internal static extern ErrorCode GetLabel(PlaceContactHandle /* maps_place_contact_h */ contact, out string label);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_contact_get_type")]
        internal static extern ErrorCode GetType(PlaceContactHandle /* maps_place_contact_h */ contact, out string type);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_contact_get_value")]
        internal static extern ErrorCode GetValue(PlaceContactHandle /* maps_place_contact_h */ contact, out string value);
    }

    internal class PlaceContactHandle : SafeMapsHandle
    {
        public PlaceContactHandle(IntPtr handle, bool ownsHandle = true) : base(handle, ownsHandle) { Destroy = PlaceContact.Destroy; }
    }
}
