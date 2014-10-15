﻿using System;

namespace TemplateDemo
{
    class SimpleTemplate
    {
        private int item0;
        private int item1;
        private int item2;
		
        public int Item0
        {
            get
            {
                return this.item0;
            }
            private set 
            {
                this.item0 = value;
            }
        }

        public int Item1
        {
            get
            {
                return this.item1;
            }
            private set 
            {
                this.item1 = value;
            }
        }

        public int Item2
        {
            get
            {
                return this.item2;
            }
            private set 
            {
                this.item2 = value;
            }
        }
    }
}