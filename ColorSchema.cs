﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace Plot3D
{
    public class ColorSchema
    {
        public enum eSchema
        {
            Autumn = 0,
            ColorCube,
            Cool,
            Copper,
            Flag,
            Hot,
            Hsv,
            Lines,
            Pink,
            Prism,
            Rainbow1,
            Rainbow2,
            Spring,
            Summer,
            Winter,
        }

        public static Color[] GetSchema(eSchema e_Schema)
        {
            if (e_Schema == eSchema.Rainbow1)
            {
                Color[] c_Rainbow = new Color[64 * 64];
                int C = 0;
                for (int Y = 0; Y < 64; Y++)
                {
                    for (int X = 0; X < 64; X++)
                    {
                        int I = Y * 64 + X;
                        double k = ((double)I) / 4095;

                        c_Rainbow[C++] = GetRainbowColor(k);
                    }
                }
                return c_Rainbow;
            }

            Byte[,] u8_RGB;
            switch (e_Schema)
            {
                case eSchema.Autumn: u8_RGB = new byte[,] { { 255, 0, 0 }, { 255, 4, 0 }, { 255, 8, 0 }, { 255, 12, 0 }, { 255, 16, 0 }, { 255, 20, 0 }, { 255, 24, 0 }, { 255, 28, 0 }, { 255, 32, 0 }, { 255, 36, 0 }, { 255, 40, 0 }, { 255, 45, 0 }, { 255, 49, 0 }, { 255, 53, 0 }, { 255, 57, 0 }, { 255, 61, 0 }, { 255, 65, 0 }, { 255, 69, 0 }, { 255, 73, 0 }, { 255, 77, 0 }, { 255, 81, 0 }, { 255, 85, 0 }, { 255, 89, 0 }, { 255, 93, 0 }, { 255, 97, 0 }, { 255, 101, 0 }, { 255, 105, 0 }, { 255, 109, 0 }, { 255, 113, 0 }, { 255, 117, 0 }, { 255, 121, 0 }, { 255, 125, 0 }, { 255, 130, 0 }, { 255, 134, 0 }, { 255, 138, 0 }, { 255, 142, 0 }, { 255, 146, 0 }, { 255, 150, 0 }, { 255, 154, 0 }, { 255, 158, 0 }, { 255, 162, 0 }, { 255, 166, 0 }, { 255, 170, 0 }, { 255, 174, 0 }, { 255, 178, 0 }, { 255, 182, 0 }, { 255, 186, 0 }, { 255, 190, 0 }, { 255, 194, 0 }, { 255, 198, 0 }, { 255, 202, 0 }, { 255, 206, 0 }, { 255, 210, 0 }, { 255, 215, 0 }, { 255, 219, 0 }, { 255, 223, 0 }, { 255, 227, 0 }, { 255, 231, 0 }, { 255, 235, 0 }, { 255, 239, 0 }, { 255, 243, 0 }, { 255, 247, 0 }, { 255, 251, 0 }, { 255, 255, 0 } }; break;
                case eSchema.ColorCube: u8_RGB = new byte[,] { { 85, 85, 0 }, { 85, 170, 0 }, { 85, 255, 0 }, { 170, 85, 0 }, { 170, 170, 0 }, { 170, 255, 0 }, { 255, 85, 0 }, { 255, 170, 0 }, { 255, 255, 0 }, { 0, 85, 128 }, { 0, 170, 128 }, { 0, 255, 128 }, { 85, 0, 128 }, { 85, 85, 128 }, { 85, 170, 128 }, { 85, 255, 128 }, { 170, 0, 128 }, { 170, 85, 128 }, { 170, 170, 128 }, { 170, 255, 128 }, { 255, 0, 128 }, { 255, 85, 128 }, { 255, 170, 128 }, { 255, 255, 128 }, { 0, 85, 255 }, { 0, 170, 255 }, { 0, 255, 255 }, { 85, 0, 255 }, { 85, 85, 255 }, { 85, 170, 255 }, { 85, 255, 255 }, { 170, 0, 255 }, { 170, 85, 255 }, { 170, 170, 255 }, { 170, 255, 255 }, { 255, 0, 255 }, { 255, 85, 255 }, { 255, 170, 255 }, { 43, 0, 0 }, { 85, 0, 0 }, { 128, 0, 0 }, { 170, 0, 0 }, { 213, 0, 0 }, { 255, 0, 0 }, { 0, 43, 0 }, { 0, 85, 0 }, { 0, 128, 0 }, { 0, 170, 0 }, { 0, 213, 0 }, { 0, 255, 0 }, { 0, 0, 43 }, { 0, 0, 85 }, { 0, 0, 128 }, { 0, 0, 170 }, { 0, 0, 213 }, { 0, 0, 255 }, { 0, 0, 0 }, { 36, 36, 36 }, { 73, 73, 73 }, { 109, 109, 109 }, { 146, 146, 146 }, { 182, 182, 182 }, { 219, 219, 219 }, { 255, 255, 255 } }; break;
                case eSchema.Cool: u8_RGB = new byte[,] { { 0, 255, 255 }, { 4, 251, 255 }, { 8, 247, 255 }, { 12, 243, 255 }, { 16, 239, 255 }, { 20, 235, 255 }, { 24, 231, 255 }, { 28, 227, 255 }, { 32, 223, 255 }, { 36, 219, 255 }, { 40, 215, 255 }, { 45, 210, 255 }, { 49, 206, 255 }, { 53, 202, 255 }, { 57, 198, 255 }, { 61, 194, 255 }, { 65, 190, 255 }, { 69, 186, 255 }, { 73, 182, 255 }, { 77, 178, 255 }, { 81, 174, 255 }, { 85, 170, 255 }, { 89, 166, 255 }, { 93, 162, 255 }, { 97, 158, 255 }, { 101, 154, 255 }, { 105, 150, 255 }, { 109, 146, 255 }, { 113, 142, 255 }, { 117, 138, 255 }, { 121, 134, 255 }, { 125, 130, 255 }, { 130, 125, 255 }, { 134, 121, 255 }, { 138, 117, 255 }, { 142, 113, 255 }, { 146, 109, 255 }, { 150, 105, 255 }, { 154, 101, 255 }, { 158, 97, 255 }, { 162, 93, 255 }, { 166, 89, 255 }, { 170, 85, 255 }, { 174, 81, 255 }, { 178, 77, 255 }, { 182, 73, 255 }, { 186, 69, 255 }, { 190, 65, 255 }, { 194, 61, 255 }, { 198, 57, 255 }, { 202, 53, 255 }, { 206, 49, 255 }, { 210, 45, 255 }, { 215, 40, 255 }, { 219, 36, 255 }, { 223, 32, 255 }, { 227, 28, 255 }, { 231, 24, 255 }, { 235, 20, 255 }, { 239, 16, 255 }, { 243, 12, 255 }, { 247, 8, 255 }, { 251, 4, 255 }, { 255, 0, 255 } }; break;
                case eSchema.Copper: u8_RGB = new byte[,] { { 0, 0, 0 }, { 5, 3, 2 }, { 10, 6, 4 }, { 15, 9, 6 }, { 20, 13, 8 }, { 25, 16, 10 }, { 30, 19, 12 }, { 35, 22, 14 }, { 40, 25, 16 }, { 46, 28, 18 }, { 51, 32, 20 }, { 56, 35, 22 }, { 61, 38, 24 }, { 66, 41, 26 }, { 71, 44, 28 }, { 76, 47, 30 }, { 81, 51, 32 }, { 86, 54, 34 }, { 91, 57, 36 }, { 96, 60, 38 }, { 101, 63, 40 }, { 106, 66, 42 }, { 111, 70, 44 }, { 116, 73, 46 }, { 121, 76, 48 }, { 126, 79, 50 }, { 132, 82, 52 }, { 137, 85, 54 }, { 142, 89, 56 }, { 147, 92, 58 }, { 152, 95, 60 }, { 157, 98, 62 }, { 162, 101, 64 }, { 167, 104, 66 }, { 172, 108, 68 }, { 177, 111, 70 }, { 182, 114, 72 }, { 187, 117, 75 }, { 192, 120, 77 }, { 197, 123, 79 }, { 202, 126, 81 }, { 207, 130, 83 }, { 212, 133, 85 }, { 218, 136, 87 }, { 223, 139, 89 }, { 228, 142, 91 }, { 233, 145, 93 }, { 238, 149, 95 }, { 243, 152, 97 }, { 248, 155, 99 }, { 253, 158, 101 }, { 255, 161, 103 }, { 255, 164, 105 }, { 255, 168, 107 }, { 255, 171, 109 }, { 255, 174, 111 }, { 255, 177, 113 }, { 255, 180, 115 }, { 255, 183, 117 }, { 255, 187, 119 }, { 255, 190, 121 }, { 255, 193, 123 }, { 255, 196, 125 }, { 255, 199, 127 } }; break;
                case eSchema.Flag: u8_RGB = new byte[,] { { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 }, { 255, 0, 0 }, { 255, 255, 255 }, { 0, 0, 255 }, { 0, 0, 0 } }; break;
                case eSchema.Hot: u8_RGB = new byte[,] { { 11, 0, 0 }, { 21, 0, 0 }, { 32, 0, 0 }, { 43, 0, 0 }, { 53, 0, 0 }, { 64, 0, 0 }, { 74, 0, 0 }, { 85, 0, 0 }, { 96, 0, 0 }, { 106, 0, 0 }, { 117, 0, 0 }, { 128, 0, 0 }, { 138, 0, 0 }, { 149, 0, 0 }, { 159, 0, 0 }, { 170, 0, 0 }, { 181, 0, 0 }, { 191, 0, 0 }, { 202, 0, 0 }, { 213, 0, 0 }, { 223, 0, 0 }, { 234, 0, 0 }, { 244, 0, 0 }, { 255, 0, 0 }, { 255, 11, 0 }, { 255, 21, 0 }, { 255, 32, 0 }, { 255, 43, 0 }, { 255, 53, 0 }, { 255, 64, 0 }, { 255, 74, 0 }, { 255, 85, 0 }, { 255, 96, 0 }, { 255, 106, 0 }, { 255, 117, 0 }, { 255, 128, 0 }, { 255, 138, 0 }, { 255, 149, 0 }, { 255, 159, 0 }, { 255, 170, 0 }, { 255, 181, 0 }, { 255, 191, 0 }, { 255, 202, 0 }, { 255, 213, 0 }, { 255, 223, 0 }, { 255, 234, 0 }, { 255, 244, 0 }, { 255, 255, 0 }, { 255, 255, 16 }, { 255, 255, 32 }, { 255, 255, 48 }, { 255, 255, 64 }, { 255, 255, 80 }, { 255, 255, 96 }, { 255, 255, 112 }, { 255, 255, 128 }, { 255, 255, 143 }, { 255, 255, 159 }, { 255, 255, 175 }, { 255, 255, 191 }, { 255, 255, 207 }, { 255, 255, 223 }, { 255, 255, 239 }, { 255, 255, 255 } }; break;
                case eSchema.Hsv: u8_RGB = new byte[,] { { 255, 0, 0 }, { 255, 24, 0 }, { 255, 48, 0 }, { 255, 72, 0 }, { 255, 96, 0 }, { 255, 120, 0 }, { 255, 143, 0 }, { 255, 167, 0 }, { 255, 191, 0 }, { 255, 215, 0 }, { 255, 239, 0 }, { 247, 255, 0 }, { 223, 255, 0 }, { 199, 255, 0 }, { 175, 255, 0 }, { 151, 255, 0 }, { 128, 255, 0 }, { 104, 255, 0 }, { 80, 255, 0 }, { 56, 255, 0 }, { 32, 255, 0 }, { 8, 255, 0 }, { 0, 255, 16 }, { 0, 255, 40 }, { 0, 255, 64 }, { 0, 255, 88 }, { 0, 255, 112 }, { 0, 255, 135 }, { 0, 255, 159 }, { 0, 255, 183 }, { 0, 255, 207 }, { 0, 255, 231 }, { 0, 255, 255 }, { 0, 231, 255 }, { 0, 207, 255 }, { 0, 183, 255 }, { 0, 159, 255 }, { 0, 135, 255 }, { 0, 112, 255 }, { 0, 88, 255 }, { 0, 64, 255 }, { 0, 40, 255 }, { 0, 16, 255 }, { 8, 0, 255 }, { 32, 0, 255 }, { 56, 0, 255 }, { 80, 0, 255 }, { 104, 0, 255 }, { 128, 0, 255 }, { 151, 0, 255 }, { 175, 0, 255 }, { 199, 0, 255 }, { 223, 0, 255 }, { 247, 0, 255 }, { 255, 0, 239 }, { 255, 0, 215 }, { 255, 0, 191 }, { 255, 0, 167 }, { 255, 0, 143 }, { 255, 0, 120 }, { 255, 0, 96 }, { 255, 0, 72 }, { 255, 0, 48 }, { 255, 0, 24 } }; break;
                case eSchema.Rainbow2: u8_RGB = new byte[,] { { 0, 0, 143 }, { 0, 0, 159 }, { 0, 0, 175 }, { 0, 0, 191 }, { 0, 0, 207 }, { 0, 0, 223 }, { 0, 0, 239 }, { 0, 0, 255 }, { 0, 16, 255 }, { 0, 32, 255 }, { 0, 48, 255 }, { 0, 64, 255 }, { 0, 80, 255 }, { 0, 96, 255 }, { 0, 112, 255 }, { 0, 128, 255 }, { 0, 143, 255 }, { 0, 159, 255 }, { 0, 175, 255 }, { 0, 191, 255 }, { 0, 207, 255 }, { 0, 223, 255 }, { 0, 239, 255 }, { 0, 255, 255 }, { 16, 255, 239 }, { 32, 255, 223 }, { 48, 255, 207 }, { 64, 255, 191 }, { 80, 255, 175 }, { 96, 255, 159 }, { 112, 255, 143 }, { 128, 255, 128 }, { 143, 255, 112 }, { 159, 255, 96 }, { 175, 255, 80 }, { 191, 255, 64 }, { 207, 255, 48 }, { 223, 255, 32 }, { 239, 255, 16 }, { 255, 255, 0 }, { 255, 239, 0 }, { 255, 223, 0 }, { 255, 207, 0 }, { 255, 191, 0 }, { 255, 175, 0 }, { 255, 159, 0 }, { 255, 143, 0 }, { 255, 128, 0 }, { 255, 112, 0 }, { 255, 96, 0 }, { 255, 80, 0 }, { 255, 64, 0 }, { 255, 48, 0 }, { 255, 32, 0 }, { 255, 16, 0 }, { 255, 0, 0 }, { 239, 0, 0 }, { 223, 0, 0 }, { 207, 0, 0 }, { 191, 0, 0 }, { 175, 0, 0 }, { 159, 0, 0 }, { 143, 0, 0 }, { 128, 0, 0 } }; break;
                case eSchema.Lines: u8_RGB = new byte[,] { { 0, 0, 255 }, { 0, 128, 0 }, { 255, 0, 0 }, { 0, 191, 191 }, { 191, 0, 191 }, { 191, 191, 0 }, { 64, 64, 64 }, { 0, 0, 255 }, { 0, 128, 0 }, { 255, 0, 0 }, { 0, 191, 191 }, { 191, 0, 191 }, { 191, 191, 0 }, { 64, 64, 64 }, { 0, 0, 255 }, { 0, 128, 0 }, { 255, 0, 0 }, { 0, 191, 191 }, { 191, 0, 191 }, { 191, 191, 0 }, { 64, 64, 64 }, { 0, 0, 255 }, { 0, 128, 0 }, { 255, 0, 0 }, { 0, 191, 191 }, { 191, 0, 191 }, { 191, 191, 0 }, { 64, 64, 64 }, { 0, 0, 255 }, { 0, 128, 0 }, { 255, 0, 0 }, { 0, 191, 191 }, { 191, 0, 191 }, { 191, 191, 0 }, { 64, 64, 64 }, { 0, 0, 255 }, { 0, 128, 0 }, { 255, 0, 0 }, { 0, 191, 191 }, { 191, 0, 191 }, { 191, 191, 0 }, { 64, 64, 64 }, { 0, 0, 255 }, { 0, 128, 0 }, { 255, 0, 0 }, { 0, 191, 191 }, { 191, 0, 191 }, { 191, 191, 0 }, { 64, 64, 64 }, { 0, 0, 255 }, { 0, 128, 0 }, { 255, 0, 0 }, { 0, 191, 191 }, { 191, 0, 191 }, { 191, 191, 0 }, { 64, 64, 64 }, { 0, 0, 255 }, { 0, 128, 0 }, { 255, 0, 0 }, { 0, 191, 191 }, { 191, 0, 191 }, { 191, 191, 0 }, { 64, 64, 64 }, { 0, 0, 255 } }; break;
                case eSchema.Pink: u8_RGB = new byte[,] { { 30, 0, 0 }, { 50, 26, 26 }, { 64, 37, 37 }, { 75, 45, 45 }, { 85, 52, 52 }, { 94, 59, 59 }, { 102, 64, 64 }, { 110, 69, 69 }, { 117, 74, 74 }, { 123, 79, 79 }, { 130, 83, 83 }, { 136, 87, 87 }, { 141, 91, 91 }, { 147, 95, 95 }, { 152, 98, 98 }, { 157, 102, 102 }, { 162, 105, 105 }, { 167, 108, 108 }, { 172, 111, 111 }, { 176, 114, 114 }, { 181, 117, 117 }, { 185, 120, 120 }, { 189, 123, 123 }, { 194, 126, 126 }, { 195, 132, 129 }, { 197, 138, 131 }, { 199, 144, 134 }, { 201, 149, 136 }, { 202, 154, 139 }, { 204, 159, 141 }, { 206, 164, 144 }, { 207, 169, 146 }, { 209, 174, 148 }, { 211, 178, 151 }, { 212, 183, 153 }, { 214, 187, 155 }, { 216, 191, 157 }, { 217, 195, 160 }, { 219, 199, 162 }, { 220, 203, 164 }, { 222, 207, 166 }, { 223, 211, 168 }, { 225, 215, 170 }, { 226, 218, 172 }, { 228, 222, 174 }, { 229, 225, 176 }, { 231, 229, 178 }, { 232, 232, 180 }, { 234, 234, 185 }, { 235, 235, 191 }, { 237, 237, 196 }, { 238, 238, 201 }, { 240, 240, 206 }, { 241, 241, 211 }, { 243, 243, 216 }, { 244, 244, 221 }, { 245, 245, 225 }, { 247, 247, 230 }, { 248, 248, 234 }, { 250, 250, 238 }, { 251, 251, 243 }, { 252, 252, 247 }, { 254, 254, 251 }, { 255, 255, 255 } }; break;
                case eSchema.Prism: u8_RGB = new byte[,] { { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 170, 0, 255 }, { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 170, 0, 255 }, { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 170, 0, 255 }, { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 170, 0, 255 }, { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 170, 0, 255 }, { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 170, 0, 255 }, { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 170, 0, 255 }, { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 170, 0, 255 }, { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 170, 0, 255 }, { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 }, { 0, 0, 255 }, { 170, 0, 255 }, { 255, 0, 0 }, { 255, 128, 0 }, { 255, 255, 0 }, { 0, 255, 0 } }; break;
                case eSchema.Spring: u8_RGB = new byte[,] { { 255, 0, 255 }, { 255, 4, 251 }, { 255, 8, 247 }, { 255, 12, 243 }, { 255, 16, 239 }, { 255, 20, 235 }, { 255, 24, 231 }, { 255, 28, 227 }, { 255, 32, 223 }, { 255, 36, 219 }, { 255, 40, 215 }, { 255, 45, 210 }, { 255, 49, 206 }, { 255, 53, 202 }, { 255, 57, 198 }, { 255, 61, 194 }, { 255, 65, 190 }, { 255, 69, 186 }, { 255, 73, 182 }, { 255, 77, 178 }, { 255, 81, 174 }, { 255, 85, 170 }, { 255, 89, 166 }, { 255, 93, 162 }, { 255, 97, 158 }, { 255, 101, 154 }, { 255, 105, 150 }, { 255, 109, 146 }, { 255, 113, 142 }, { 255, 117, 138 }, { 255, 121, 134 }, { 255, 125, 130 }, { 255, 130, 125 }, { 255, 134, 121 }, { 255, 138, 117 }, { 255, 142, 113 }, { 255, 146, 109 }, { 255, 150, 105 }, { 255, 154, 101 }, { 255, 158, 97 }, { 255, 162, 93 }, { 255, 166, 89 }, { 255, 170, 85 }, { 255, 174, 81 }, { 255, 178, 77 }, { 255, 182, 73 }, { 255, 186, 69 }, { 255, 190, 65 }, { 255, 194, 61 }, { 255, 198, 57 }, { 255, 202, 53 }, { 255, 206, 49 }, { 255, 210, 45 }, { 255, 215, 40 }, { 255, 219, 36 }, { 255, 223, 32 }, { 255, 227, 28 }, { 255, 231, 24 }, { 255, 235, 20 }, { 255, 239, 16 }, { 255, 243, 12 }, { 255, 247, 8 }, { 255, 251, 4 }, { 255, 255, 0 } }; break;
                case eSchema.Summer: u8_RGB = new byte[,] { { 0, 128, 102 }, { 4, 130, 102 }, { 8, 132, 102 }, { 12, 134, 102 }, { 16, 136, 102 }, { 20, 138, 102 }, { 24, 140, 102 }, { 28, 142, 102 }, { 32, 144, 102 }, { 36, 146, 102 }, { 40, 148, 102 }, { 45, 150, 102 }, { 49, 152, 102 }, { 53, 154, 102 }, { 57, 156, 102 }, { 61, 158, 102 }, { 65, 160, 102 }, { 69, 162, 102 }, { 73, 164, 102 }, { 77, 166, 102 }, { 81, 168, 102 }, { 85, 170, 102 }, { 89, 172, 102 }, { 93, 174, 102 }, { 97, 176, 102 }, { 101, 178, 102 }, { 105, 180, 102 }, { 109, 182, 102 }, { 113, 184, 102 }, { 117, 186, 102 }, { 121, 188, 102 }, { 125, 190, 102 }, { 130, 192, 102 }, { 134, 194, 102 }, { 138, 196, 102 }, { 142, 198, 102 }, { 146, 200, 102 }, { 150, 202, 102 }, { 154, 204, 102 }, { 158, 206, 102 }, { 162, 208, 102 }, { 166, 210, 102 }, { 170, 212, 102 }, { 174, 215, 102 }, { 178, 217, 102 }, { 182, 219, 102 }, { 186, 221, 102 }, { 190, 223, 102 }, { 194, 225, 102 }, { 198, 227, 102 }, { 202, 229, 102 }, { 206, 231, 102 }, { 210, 233, 102 }, { 215, 235, 102 }, { 219, 237, 102 }, { 223, 239, 102 }, { 227, 241, 102 }, { 231, 243, 102 }, { 235, 245, 102 }, { 239, 247, 102 }, { 243, 249, 102 }, { 247, 251, 102 }, { 251, 253, 102 }, { 255, 255, 102 } }; break;
                case eSchema.Winter: u8_RGB = new byte[,] { { 0, 0, 255 }, { 0, 4, 253 }, { 0, 8, 251 }, { 0, 12, 249 }, { 0, 16, 247 }, { 0, 20, 245 }, { 0, 24, 243 }, { 0, 28, 241 }, { 0, 32, 239 }, { 0, 36, 237 }, { 0, 40, 235 }, { 0, 45, 233 }, { 0, 49, 231 }, { 0, 53, 229 }, { 0, 57, 227 }, { 0, 61, 225 }, { 0, 65, 223 }, { 0, 69, 221 }, { 0, 73, 219 }, { 0, 77, 217 }, { 0, 81, 215 }, { 0, 85, 213 }, { 0, 89, 210 }, { 0, 93, 208 }, { 0, 97, 206 }, { 0, 101, 204 }, { 0, 105, 202 }, { 0, 109, 200 }, { 0, 113, 198 }, { 0, 117, 196 }, { 0, 121, 194 }, { 0, 125, 192 }, { 0, 130, 190 }, { 0, 134, 188 }, { 0, 138, 186 }, { 0, 142, 184 }, { 0, 146, 182 }, { 0, 150, 180 }, { 0, 154, 178 }, { 0, 158, 176 }, { 0, 162, 174 }, { 0, 166, 172 }, { 0, 170, 170 }, { 0, 174, 168 }, { 0, 178, 166 }, { 0, 182, 164 }, { 0, 186, 162 }, { 0, 190, 160 }, { 0, 194, 158 }, { 0, 198, 156 }, { 0, 202, 154 }, { 0, 206, 152 }, { 0, 210, 150 }, { 0, 215, 148 }, { 0, 219, 146 }, { 0, 223, 144 }, { 0, 227, 142 }, { 0, 231, 140 }, { 0, 235, 138 }, { 0, 239, 136 }, { 0, 243, 134 }, { 0, 247, 132 }, { 0, 251, 130 }, { 0, 255, 128 } }; break;
                default:
                    throw new Exception("Invalid enum");
            }

            Color[] c_Schema = new Color[u8_RGB.GetLength(0)];
            for (int i = 0; i < c_Schema.Length; i++)
            {
                c_Schema[i] = Color.FromArgb(u8_RGB[i, 0], u8_RGB[i, 1], u8_RGB[i, 2]);
            }
            return c_Schema;
        }

        private static Color GetRainbowColor(double k)
        {
            if (k < 0) k = 0;
            if (k > 1) k = 1;

            double r, g, b;
            if (k < 0.25)
            {
                r = 0;
                g = 4 * k;
                b = 1;
            }
            else if (k < 0.5)
            {
                r = 0;
                g = 1;
                b = 1 - 4 * (k - 0.25);
            }
            else if (k < 0.75)
            {
                r = 4 * (k - 0.5);
                g = 1;
                b = 0;
            }
            else
            {
                r = 1;
                g = 1 - 4 * (k - 0.75);
                b = 0;
            }

            byte R = (byte)(r * 255);
            byte G = (byte)(g * 255);
            byte B = (byte)(b * 255);

            return Color.FromArgb(255, R, G, B);
        }
    }
}
