using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BobbyCarrot
{
    class Button
    {
        public Texture2D TextureButton;     //текстура для кнопки
        private bool IsPressed;             //нажата ли кнопка
        public bool IsEnabled;              //кликабельна ли кнопка

        public Button(Texture2D texture)
        {
            this.TextureButton = texture;
            this.IsEnabled = true;
            this.IsPressed = false;
        }

        public Button(bool isEn, bool isPr, Texture2D texture)
        {
            this.IsEnabled = isEn;
            this.IsPressed = isPr;
            this.TextureButton = texture;
        }

        public void Update()
        {

        }
    }
}
