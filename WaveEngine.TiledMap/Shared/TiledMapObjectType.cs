﻿#region File Description
//-----------------------------------------------------------------------------
// TiledMapObjectType
//
// Copyright © 2014 Wave Corporation
// Use is subject to license terms.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace WaveEngine.TiledMap
{
    /// <summary>
    /// Object type
    /// </summary>
    public enum TiledMapObjectType
    {
        /// <summary>
        /// Basic rectangle object
        /// </summary>
        Basic,

        /// <summary>
        /// object associated to a tile
        /// </summary>
        Tile,

        /// <summary>
        /// Ellipse object
        /// </summary>
        Ellipse,

        /// <summary>
        /// Poligon that conform the object
        /// </summary>
        Polygon,

        /// <summary>
        /// Polyline that describes the object
        /// </summary>
        Polyline
    }
}