﻿//----------------------------------------------------------------------------
//
//  Copyright (C) 2004-2013 by EMGU. All rights reserved.
//
//  Vector of VectorOfInt
//
//  This file is automatically generated, do not modify.
//----------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Emgu.CV.Structure;

namespace Emgu.CV.Util
{
   /// <summary>
   /// Wraped class of the C++ standard vector of VectorOfInt.
   /// </summary>
   public partial class VectorOfVectorOfInt : Emgu.Util.UnmanagedObject, IInputArray, IOutputArray, IInputOutputArray
   {
      /// <summary>
      /// Convert the standard vector to arrays of int
      /// </summary>
      /// <returns>Arrays of Point</returns>
      public int[][] ToArrayOfArray()
      {
         int size = Size;
         int[][] res = new int[size][];
         for (int i = 0; i < size; i++)
         {
            using (VectorOfInt v = this[i])
            {
               res[i] = v.ToArray();
            }
         }
         return res;
      }
   }
}