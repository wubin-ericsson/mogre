/*
 Miyagi v1.2.1
 Copyright (c) 2008 - 2012 Tobias Bohnen

 Permission is hereby granted, free of charge, to any person obtaining a copy of this
 software and associated documentation files (the "Software"), to deal in the Software
 without restriction, including without limitation the rights to use, copy, modify, merge,
 publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 to whom the Software is furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in all copies or
 substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 DEALINGS IN THE SOFTWARE.
 */
namespace Miyagi.Common.Events
{
    using Miyagi.Common.Data;

    /// <summary>
    /// EventArgs for mouse events.
    /// </summary>
    public class MouseEventArgs : MiyagiEventArgs
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the MouseEventArgs class.
        /// </summary>
        /// <param name="mouseLoc">The mouse coordinates.</param>
        public MouseEventArgs(Point mouseLoc)
        {
            this.MouseLocation = mouseLoc;
        }

        #endregion Constructors

        #region Properties

        #region Public Properties

        /// <summary>
        /// Gets the mouse location.
        /// </summary>
        public Point MouseLocation
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the x-coordinate of the mouse.
        /// </summary>
        public int MouseX
        {
            get
            {
                return this.MouseLocation.X;
            }
        }

        /// <summary>
        /// Gets the y-coordinate of the mouse.
        /// </summary>
        public int MouseY
        {
            get
            {
                return this.MouseLocation.Y;
            }
        }

        #endregion Public Properties

        #endregion Properties
    }
}