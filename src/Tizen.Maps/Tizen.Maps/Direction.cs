﻿/*
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

namespace Tizen.Maps
{
    /// <summary>
    /// Direction types for route maneuver
    /// </summary>
    public enum DirectionType
    {
        /// <summary>
        /// Unknown direction
        /// </summary>
        None = Interop.RouteDirection.None,
        /// <summary>
        /// North direction
        /// </summary>
        North = Interop.RouteDirection.North,
        /// <summary>
        /// North-West direction
        /// </summary>
        NorthWest = Interop.RouteDirection.NorthWest,
        /// <summary>
        /// North-East direction
        /// </summary>
        NorthEast = Interop.RouteDirection.NorthEast,
        /// <summary>
        /// South direction
        /// </summary>
        South = Interop.RouteDirection.South,
        /// <summary>
        /// South-East direction
        /// </summary>
        SouthEast = Interop.RouteDirection.SouthEast,
        /// <summary>
        /// South-West direction
        /// </summary>
        SouthWest = Interop.RouteDirection.SouthWest,
        /// <summary>
        /// West direction
        /// </summary>
        West = Interop.RouteDirection.West,
        /// <summary>
        /// East direction
        /// </summary>
        East = Interop.RouteDirection.East,
    }
}
