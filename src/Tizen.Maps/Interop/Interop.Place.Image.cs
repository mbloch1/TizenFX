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
    internal static partial class PlaceImage
    {
        [DllImport(Libraries.MapService, EntryPoint = "maps_place_image_destroy")]
        internal static extern ErrorCode Destroy(IntPtr /* maps_place_image_h */ image);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_image_clone")]
        internal static extern ErrorCode Clone(PlaceImageHandle /* maps_place_image_h */ origin, out IntPtr /* maps_place_image_h */ cloned);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_image_get_id")]
        internal static extern ErrorCode GetId(PlaceImageHandle /* maps_place_image_h */ image, out string id);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_image_get_url")]
        internal static extern ErrorCode GetUrl(PlaceImageHandle /* maps_place_image_h */ image, out string url);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_image_get_width")]
        internal static extern ErrorCode GetWidth(PlaceImageHandle /* maps_place_image_h */ image, out int width);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_image_get_height")]
        internal static extern ErrorCode GetHeight(PlaceImageHandle /* maps_place_image_h */ image, out int height);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_image_get_user_link")]
        internal static extern ErrorCode GetUserLink(PlaceImageHandle /* maps_place_image_h */ image, out IntPtr /* maps_place_link_object_h */ user);

        [DllImport(Libraries.MapService, EntryPoint = "maps_place_image_get_media")]
        internal static extern ErrorCode GetMedia(PlaceImageHandle /* maps_place_image_h */ image, out IntPtr /* maps_place_media_h */ media);
    }

    internal class PlaceImageHandle : SafeMapsHandle
    {
        public PlaceImageHandle(IntPtr handle, bool ownsHandle = true) : base(handle, ownsHandle) { Destroy = PlaceImage.Destroy; }
    }
}
