using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BobbyCarrot
{
    class Button
    {
        public Texture2D TextureButton { get; set; }            //текстура для кнопки в не нажатом состоянии
        public Texture2D TextureButtonPressed { get; set; }     //текстура для кнопки в нажатом состоянии
        private bool IsPressed { get; set; }                    //нажата ли кнопка
        public bool IsEnabled { get; set; }                     //кликабельна ли кнопка


        public Button()
        {
            this.IsEnabled = true;
            this.IsPressed = false;
        }


        public Button(bool isEn, bool isPr, Texture2D texture1, Texture2D texture2)
        {
            this.IsEnabled = isEn;
            this.IsPressed = isPr;
            this.TextureButton = texture1;
            this.TextureButtonPressed = texture2;
        }

        public void Update()
        {

        }
    }
}
