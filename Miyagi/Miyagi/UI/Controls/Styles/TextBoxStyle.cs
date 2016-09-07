﻿/*
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
namespace Miyagi.UI.Controls.Styles
{
    /// <summary>
    /// The style of a TextBoxElement.
    /// </summary>
    public class TextBoxStyle : EditBoxStyle
    {
        #region Fields

        private bool digitOnly;
        private bool letterOrDigitOnly;

        #endregion Fields

        #region Properties

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether only numbers should be accepted as input by the TextBox.
        /// </summary>
        public bool DigitOnly
        {
            get
            {
                return this.digitOnly;
            }

            set
            {
                if (this.digitOnly != value)
                {
                    this.OnPropertyChanging("DigitOnly");
                    this.digitOnly = value;
                    this.OnPropertyChanged("DigitOnly");
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether only alphanumeric characters should be accepted as input by the TextBox.
        /// </summary>
        public bool LetterOrDigitOnly
        {
            get
            {
                return this.letterOrDigitOnly;
            }

            set
            {
                if (this.letterOrDigitOnly != value)
                {
                    this.OnPropertyChanging("LetterOrDigitOnly");
                    this.letterOrDigitOnly = value;
                    this.OnPropertyChanged("LetterOrDigitOnly");
                }
            }
        }

        #endregion Public Properties

        #endregion Properties
    }
}