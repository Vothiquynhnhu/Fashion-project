using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Fashion.Entity;

namespace Web_Fashion.Data.DataSeeding
{
    public static class InsertData
    {
        public static void Seed(this ModelBuilder builder)
        {


            //var hasher = new PasswordHasher<AppUsers>();



            //Table Products
            builder.Entity<Products>().HasData(
                new Products()
                {
                    pd_Id = 1,
                    pd_Name = "OFF-WHITE ARROWS PRINT COTTON SLIM T-SHIRT - BLACK/PURPLE/RED",
                    pd_Description = "black / purple / red ,cotton, signature arrow pattern, logo print on chest, round neck, short sleeves, straight border",
                    pd_Price = 80,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product1-blue.png",
                    pd_Img2 = "./img/Product1-brown.png",
                    pd_Img3 = "./img/Product1-white.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Off White",
                    pd_Style = "",
                    pd_Color = "Black",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 =true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 =true,
                    pd_Size12 =true,
                    pd_Size12_5= true,
                    pd_Size13_5=true,
                    pd_Size14 = true,
                    pd_Size14_5 =true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD001"
                   


                },

                new Products()
                {
                    pd_Id = 2,
                    pd_Name = "OFF-WHITE ARROWS PRINT SHORT-SLEEVE T-SHIRT - BLACK/GREY SS21",
                    pd_Description = "",
                    pd_Price = 50,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product2-black.jpg",
                    pd_Img2 = "./img/Product2-gray.jpg",
                    pd_Img3 = "./img/Product2-purple.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Off White",
                    pd_Style = "",
                    pd_Color = "Black",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD002"

                },

                new Products()
                {
                    pd_Id = 3,
                    pd_Name = "OFF-WHITE ARROWS PRINT SHORT-SLEEVE T-SHIRT - WHITE/BLUE SS21",
                    pd_Description = "White, cotton, signature arrow pattern, logo print on chest, round neck, short sleeves, straight border",
                    pd_Price = 40,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product3-black.jpg",
                    pd_Img2 = "./img/Product3-blue.jpg",
                    pd_Img3 = "./img/Product3-white.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Off White",
                    pd_Style = "",
                    pd_Color = "White/Blue",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD003"

                },

                new Products()
                {
                    pd_Id = 4,
                    pd_Name = "ANDREA MARTIN Grey Astronaut Mesh Shirt",
                    pd_Description = "",
                    pd_Price = 90,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product4-blue.jpg",
                    pd_Img2 = "./img/Product4-cream.jpg",
                    pd_Img3 = "./img/Product4-white.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Andrea Martin",
                    pd_Style = "Slim 3-layer mesh top",
                    pd_Color = "Gray",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD004"

                },

                new Products()
                {
                    pd_Id = 5,
                    pd_Name = "BURBERRY SHIRT",
                    pd_Description = "- The shirt is made of breathable cotton fabric, good sweat absorption, bringing comfort to the wearer. Beautiful standard shirt form, delicate seams meticulous detail to satisfy even fastidious customers.",
                    pd_Price = 99,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product5-black.jpg",
                    pd_Img2 = "./img/Product5-blue.jpg",
                    pd_Img3 = "./img/Product5-yellow.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Burberry",
                    pd_Style = "Shirt",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD005"

                },

                new Products()
                {
                    pd_Id = 6,
                    pd_Name = "ADLV SHIRT",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product6-black.jpg",
                    pd_Img2 = "./img/Product6-gray.jpg",
                    pd_Img3 = "./img/Product6-white.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "ADLV",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD006"

                },

                new Products()
                {
                    pd_Id = 7,
                    pd_Name = "BURBERRY SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product7-blue.png",
                    pd_Img2 = "./img/Product7-white.png",
                    pd_Img3 = "./img/Product7-yellow.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Burberry",
                    pd_Style = "Shirt",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD007"

                },

                new Products()
                {
                    pd_Id = 8,
                    pd_Name = "BURBERRY MONOGRAM MOTIF STRETCH COTTON POPLIN SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product8-pink.jpg",
                    pd_Img2 = "./img/Product8-white.jpg",
                    pd_Img3 = "./img/Product8-yellow.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "eteft",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD008"

                },

                new Products()
                {
                    pd_Id = 9,
                    pd_Name = "THOM BROWN SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product9-black.png",
                    pd_Img2 = "./img/Product9-blue.png",
                    pd_Img3 = "./img/Product9-red.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Thom Browne",
                    pd_Style = "Shirt",
                    pd_Color = "White",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD009"

                },

                new Products()
                {
                    pd_Id = 10,
                    pd_Name = "BURBERRY SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product10-blue.png",
                    pd_Img2 = "./img/Product10-pink.jpg",
                    pd_Img3 = "./img/Product10-white.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Burberry",
                    pd_Style = "Shirt",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD010"

                },

                new Products()
                {
                    pd_Id = 12,
                    pd_Name = "BURBERRY SHIRT LIGHT BROWN",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product12-black.jpg",
                    pd_Img2 = "./img/Product12-red.jpg",
                    pd_Img3 = "./img/Product12-yellow.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "eteft",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD012"

                },

                new Products()
                {
                    pd_Id = 13,
                    pd_Name = "BURBERRY SHIRT LIGHT BROWN",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product13-dark-blue.jpg",
                    pd_Img2 = "./img/Product13-green.jpg",
                    pd_Img3 = "./img/Product13-pink.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "eteft",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD013"

                },

                new Products()
                {
                    pd_Id = 14,
                    pd_Name = "THOM BROWNE WHITE SHORT SLEEVE SHIRT",
                    pd_Description = "Endless styling opportunities are in store with this Thom Browne shirt. Made from breathable cotton, this piece is both cool and comfortable. Talk about no trouble. Features a button-down collar, front button closure, open front pockets, curved hemline, front logo patch and tricolor stripe detail with buttons on both sleeves",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product14-black.jpg",
                    pd_Img2 = "./img/Product14-white.jpg",
                    pd_Img3 = "./img/Product14-yellow.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Thom Browne",
                    pd_Style = "Shirt",
                    pd_Color = "White",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD014"

                },

                new Products()
                {
                    pd_Id = 15,
                    pd_Name = "GUCCI GG STRETCH COTTON POLO - DARK GREEN",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product15-gray.jpg",
                    pd_Img2 = "./img/Product15-green.jpg",
                    pd_Img3 = "./img/Product15-yellow.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "eteft",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD015"

                },



                // Women
                new Products()
                {
                    pd_Id = 16,
                    pd_Name = "MOSCHINO T-SHIRT GOLD LOGO WITH PIG",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product16-black.jpg",
                    pd_Img2 = "./img/Product16-red.jpg",
                    pd_Img3 = "./img/Product16-white.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Moschino",
                    pd_Style = "T-shirt",
                    pd_Color = "Black",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD016"

                },

                new Products()
                {
                    pd_Id = 17,
                    pd_Name = "MOSCHINO TEE WARRIOR",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product17-black.jpg",
                    pd_Img2 = "./img/Product17-blue.jpg",
                    pd_Img3 = "./img/Product17-gray.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Moschino",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD017"

                },

                new Products()
                {
                    pd_Id = 18,
                    pd_Name = "MOSCHINO TEE DOLLARS",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product18-gray.jpg",
                    pd_Img2 = "./img/Product18-pink.jpg",
                    pd_Img3 = "./img/Product18-white.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Moschino",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD018"

                },

                new Products()
                {
                    pd_Id = 19,
                    pd_Name = "MOSCHINO T-SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product19-blue.jpg",
                    pd_Img2 = "./img/Product19-red.jpg",
                    pd_Img3 = "./img/Product19-yellow.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Moschino",
                    pd_Style = "T-shirt",
                    pd_Color = "White",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD019"

                },

                new Products()
                {
                    pd_Id = 20,
                    pd_Name = "MOSCHINO T-SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product20-black.jpg",
                    pd_Img2 = "./img/Product20-pink.jpg",
                    pd_Img3 = "./img/Product20-white.jpg",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Moschino",
                    pd_Style = "T-shirt",
                    pd_Color = "White",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD020"

                },

                new Products()
                {
                    pd_Id = 21,
                    pd_Name = "MOSCHINO T-SHIRT COUTURE",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product21-blue.png",
                    pd_Img2 = "./img/Product21-cream.png",
                    pd_Img3 = "./img/Product21-gray.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Moschino",
                    pd_Style = "T-shirt",
                    pd_Color = "Black",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD021"

                },

                new Products()
                {
                    pd_Id = 22,
                    pd_Name = "SUPREME SPIRAL T-SHIRT - WHITE",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product22-blue.png",
                    pd_Img2 = "./img/Product22-gray.png",
                    pd_Img3 = "./img/Product22-green.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Supreme",
                    pd_Style = "T-shirt",
                    pd_Color = "White",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD022"

                },

                new Products()
                {
                    pd_Id = 23,
                    pd_Name = "SUPREME SPIRAL T-SHIRT - BLACK",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product23-black.png",
                    pd_Img2 = "./img/Product23-blue.png",
                    pd_Img3 = "./img/Product23-redjpg.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Supreme",
                    pd_Style = "T-shirt",
                    pd_Color = "Black",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD023"

                },

                new Products()
                {
                    pd_Id = 24,
                    pd_Name = "SUPREME CROSS BOX LOGO T-SHIRT - NAVY",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product24-black.png",
                    pd_Img2 = "./img/Product24-blue.png",
                    pd_Img3 = "./img/Product24-brown.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "eteft",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD024"

                },

                new Products()
                {
                    pd_Id = 25,
                    pd_Name = "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK DONUTS 1",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product25-black.png",
                    pd_Img2 = "./img/Product25-blue.png",
                    pd_Img3 = "./img/Product25-cream.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "ADLV",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD025"

                },

                new Products()
                {
                    pd_Id = 26,
                    pd_Name = "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK ASTRONAUT",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product26-black.png",
                    pd_Img2 = "./img/Product26-blue.png",
                    pd_Img3 = "./img/Product26-cream.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "ADLV",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD026"
                },

                new Products()
                {
                    pd_Id = 27,
                    pd_Name = "ADLV ASTRONAUT TRIO SHORT SLEEVE T-SHIRT - BLACK",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product27-black.png",
                    pd_Img2 = "./img/Product27-gray.png",
                    pd_Img3 = "./img/Product27-purple.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "ADLV",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD027"

                },

                new Products()
                {
                    pd_Id = 28,
                    pd_Name = "ADLV RAINBOW CLOUD LOGO SHORT SLEEVE T-SHIRT BLACK",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product28-black.png",
                    pd_Img2 = "./img/Product28-gray.png",
                    pd_Img3 = "./img/Product28-purple.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "ADLV",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD028"

                },

                new Products()
                {
                    pd_Id = 29,
                    pd_Name = "ADLV TEDDY BEAR SHORT SLEEVE T-SHIRT BLACK",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product29-blue.png",
                    pd_Img2 = "./img/Product29-gray.png",
                    pd_Img3 = "./img/Product29-green.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "ADLV",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD029"

                },

                new Products()
                {
                    pd_Id = 30,
                    pd_Name = "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK RABBIT",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "./img/Product30-black.png",
                    pd_Img2 = "./img/Product30-brown.png",
                    pd_Img3 = "./img/Product30-brown.png",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "ADLV",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4",
                    pd_Code = "PD030"

                }
                );




        //Table About
        builder.Entity<About>().HasData(
                new About()
                {
                    about_id=1,
                    about_Url= "https://www.youtube.com/watch?v=F1vcruph8JA",
                    about_Title = "Footwear the leading eCommerce Store around the Globe",
                    about_Description = "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way."
                });

            var IdRoleStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd";
            var IdRoleAdmin = "360E601E-92F2-4F08-832B-604A21293258";



            //Table AppRole 2222222222222222222222222222222222222222222222222222222222222222222

            builder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = IdRoleStaff,
                    Name ="Staff",
                    Description = "Staff",
                    NormalizedName = "STAFF"

                },
                new AppRole()
                {
                    Id = IdRoleAdmin,
                    Name = "Admin",
                    Description = "Admin",
                    NormalizedName = "ADMIN"
                });


            var IdStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff";
            var IdAdmin = "DE544998-A3CC-4E12-ABB4-0642E57BD222";

            //Table AppUser 2222222222222222222222222222222222222222222222222222222222222222222

            var hasher = new PasswordHasher<AppUser>();

            builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = IdAdmin,
                UserName = "Admin",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123@123Aa"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "admin",
                LastName = "admin",
                DoB = new DateTime(2020, 01, 02),
                bill_City = "HCM",
                bill_Address1 = "HCM 1",
                bill_Address2 = "HCM 2",
                bill_Country = "Viet Nam",
                bill_CompanyName = "0123456789",
                bill_PhoneNumber = "0112223344",
                bill_PostalCode = "700000",
                bill_State = "700000"
                

            },
            new AppUser
            {
                Id = IdStaff,
                UserName = "Staff",
                NormalizedUserName = "STAFF@GMAIL.COM",
                NormalizedEmail = "STAFF@GMAIL.COM",
                Email = "staff@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123@123Aa"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "staff",
                LastName = "staff",
                DoB = new DateTime(2020, 03, 02)

            });


            //Table AppUser - role 2222222222222222222222222222222222222222222222222222222222222222222
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = IdRoleStaff,
                UserId = IdStaff
            },
            new IdentityUserRole<string>
            {
                RoleId = IdRoleAdmin,
                UserId = IdAdmin
            });





            var IdCart1 = "72309286-ECBB-4D20-AD95-2819D31E3400";
            var IdCart2 = "D355458F-1DD3-4834-AA28-6DA34B6357FF";


            //Table Cart

            builder.Entity<Cart>().HasData(
                new Cart()
                {
                    cart_Id = IdCart1,
                    cart_UserID = IdStaff

                },
                new Cart()
                {
                    cart_Id = IdCart2,
                    cart_UserID = IdAdmin

                });

            var IdPic1 = Guid.NewGuid().ToString();
            var IdPic2 = Guid.NewGuid().ToString();
            var IdPic3 = Guid.NewGuid().ToString();

            //Table Product In Cart

            builder.Entity<ProductInCart>().HasData(
                new ProductInCart()
                {
                     pic_Id = IdPic1,
                     pic_CartId = IdCart2,
                     pic_ProductId =1,
                     pic_amount = 2,
                     pic_size = "7",
                     pic_color = "blue"

                },
                new ProductInCart()
                {
                    pic_Id = IdPic2,
                    pic_CartId = IdCart2,
                    pic_ProductId = 2,
                    pic_amount = 3,
                    pic_size = "7.5",
                    pic_color = "blue"

                },
                new ProductInCart()
                {
                    pic_Id = IdPic3,
                    pic_CartId = IdCart2,
                    pic_ProductId = 3,
                    pic_amount = 1,
                    pic_size = "8",
                    pic_color = "blue"
                });


            //Table Categories





            builder.Entity<Categories>().HasData(
                new Categories()
                {
                    cg_Id = 1,
                    cg_Name = "women",
                    cg_Type = "",
                    cg_Sale = ""

                },
                new Categories()
                {
                    cg_Id = 2,
                    cg_Name = "Man",
                    cg_Type = "",
                    cg_Sale = ""

                },
                new Categories()
                {
                    cg_Id = 3,
                    cg_Name = "BestSeller",
                    cg_Type = "",
                    cg_Sale = ""

                },
                new Categories()
                {
                    cg_Id = 4,
                    cg_Name = "TopSeller",
                    cg_Type = "",
                    cg_Sale = ""

                },
                new Categories()
                {
                    cg_Id = 5,
                    cg_Name = "Hangbag",
                    cg_Type = "",
                    cg_Sale = ""

                });





            //Table ContactSystem

            builder.Entity<ContactSystem>().HasData(
                new ContactSystem()
                {
                    Contact_Id = 1,
                    Contact_Address = " 123, An Lac A Ward, Binh Tan District, HCM",
                    Contact_Phone = "0123456789",
                    Contact_Email = "admin@gmail.com",
                    Contact_Website = "https://shoes.com"


                });



            //Table ContactUsers


            builder.Entity<ContactUsers>().HasData(
                new ContactUsers()
                {
                    cu_Id = 1,
                    cu_FirstName = "FirstName",
                    cu_LastName = "LastName",
                    cu_Email = "Email",
                    cu_Subject = "Subject",
                    cu_Description = "Description"
                });


            var ReviewId1 = "EEBA6608-AB75-4E83-909F-604B1A06F16C";

            var ReviewId2 = "9EED8607-D2BB-45EE-AEE3-C59D858A7F97";

            var ReviewId3 = "C2A543C2-B1E2-4DC5-A131-9137E4673FA6";




            //Table Reviews new DateTime(2020, 01, 02)


            builder.Entity<Reviews>().HasData(
                new Reviews()
                {
                    review_id = ReviewId1,
                    review_Comment = "Test",
                    review_UserId = IdAdmin,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                },
                new Reviews()
                {
                    review_id = ReviewId2,
                    review_Comment = "Test",
                    review_UserId = IdStaff,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                },
                new Reviews()
                {
                    review_id = ReviewId3,
                    review_Comment = "Test",
                    review_UserId = IdAdmin,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                });

            var SubReviewId1 = Guid.NewGuid().ToString(); 

            var SubReviewId2 = Guid.NewGuid().ToString();

            var SubReviewId3 = Guid.NewGuid().ToString();


            // Table SubReview 

            builder.Entity<SubReview>().HasData(
                new SubReview()
                {
                    subReview_Id = SubReviewId1,
                    subReview_UserId = IdAdmin,
                    subReview_Commnet = "subreview 1",
                    subReview_DateCommnet = new DateTime(2020, 01, 02),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                },
                new SubReview()
                {
                    subReview_Id = SubReviewId2,
                    subReview_UserId = IdStaff,
                    subReview_Commnet = "subreview 3",
                    subReview_DateCommnet = new DateTime(2020, 01, 03),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                },
                new SubReview()
                {
                    subReview_Id = SubReviewId3,
                    subReview_UserId = IdAdmin,
                    subReview_Commnet = "subreview 3",
                    subReview_DateCommnet = new DateTime(2020, 01, 03),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                }
                );

            builder.Entity<SubReviewInReview>().HasData(
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId1,
                    SRiR_SubReviewId = SubReviewId1
                },
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId1,
                    SRiR_SubReviewId = SubReviewId2
                },
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId2,
                    SRiR_SubReviewId = SubReviewId3
                }
                );




            //Table Wishlist


            builder.Entity<Wishlists>().HasData(
                new Wishlists()
                {
                    wl_Id = 1,
                    wl_UserId = IdStaff

                });






            //Table ProductInCategories




            builder.Entity<ProductsInCategories>().HasData(
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 12
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 13
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 14
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 15
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 16
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 17
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 18
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 19
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 20
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 1
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 2
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 3
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 4
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 5
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 6
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 7
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 8
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 9
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 10
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 21
                }
                ,
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 22
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 23
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 24
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 25
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 26
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 27
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 28
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 29
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 30
                });

            //Table ProductInCategories



            builder.Entity<ProductInWishlist>().HasData(
                new ProductInWishlist()
                {
                    piw_ProductId = 1,
                    piw_WishlistId = 1
                });




            //Table ReviewInproduct



            builder.Entity<ReviewInproduct>().HasData(
                new ReviewInproduct()
                {
                    rip_ProductId = 1,
                    rip_ReviewId = ReviewId1,
                },
                new ReviewInproduct()
                {
                    rip_ProductId = 1,
                    rip_ReviewId = ReviewId2,
                },
                new ReviewInproduct()
                {
                    rip_ProductId = 1,
                    rip_ReviewId = ReviewId3,
                });


            builder.Entity<Coupons>().HasData(
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode ="code10",
                    couponPrice = 10,
                    couponAmount = 20
                },
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode = "code50",
                    couponPrice = 50,
                    couponAmount = 25
                });



            string billId1 = "D269BF93-A5E2-4C4A-8146-9967DDE80D30";
            string billId2 = "AFD66490-12F5-4EA7-BFF6-425624290D6D";

            //Table Bills

            builder.Entity<Bills>().HasData(
                new Bills()
                {
                    bill_Id = billId1,
                    bill_UserId = IdStaff,
                    bill_PaidTotal = 2000,
                    bill_ProductIdlist = "1|2|3|4",
                    bill_ProductNamelist = "product 1|product 2| product 3| product 4",
                    bill_ProductSizelist = "7|8|9|14",
                    bill_ProductColorlist = "Blue|Red|Black|Green",
                    bill_ProductPricelist = "550|450|350|640",
                    bill_Shipping = 10,
                    bill_Discount = 0,
                    bill_Confirmation = true,
                    bill_DatetimeOrder = DateTime.Now,
                    bill_PaymentMethod = "Check Payment",
                    bill_Note = "",
                    bill_Quantity = "1|1|2|1",
                    bill_HideStatus = false,
                    bill_WaitForConfirmation = false,
                    bill_WaitPickup = false,
                    bill_Delivering = false,
                    bill_Delivered =  false,
                    bill_Cancelled = false
                },

                new Bills()
                {
                    bill_Id = billId2,
                    bill_UserId = IdStaff,
                    bill_PaidTotal = 2100,
                    bill_ProductIdlist = "5|6|7|8",
                    bill_ProductNamelist = "product 5|product 6| product 7| product 8",
                    bill_ProductSizelist = "7|8|9|14",
                    bill_ProductColorlist = "Blue|Red|Black|Green",
                    bill_ProductPricelist = "550|450|350|640",
                    bill_Shipping = 10,
                    bill_Discount = 0,
                    bill_Confirmation = true,
                    bill_DatetimeOrder = DateTime.Now,
                    bill_PaymentMethod = "Check Payment",
                    bill_Note = "",
                    bill_Quantity = "1|1|2|2",
                    bill_WaitForConfirmation = false,
                    bill_HideStatus = false,

                    bill_WaitPickup = false,
                    bill_Delivering = false,
                    bill_Delivered = false,
                    bill_Cancelled = false
                }); ;

            //Table Shiping

            string shipId = "7CF94A7D-9239-446E-A404-086518F84652";

            builder.Entity<Shipping>().HasData(
                new Shipping()
                {
                    ship_Id = shipId,
                    ship_Name ="Ship",
                    ship_Price = 1
                });


            // Home -----------------------------------------------------------------------------------
            // Table Slider-Home
            builder.Entity<SliderHome>().HasData(
                new SliderHome()
                {
                    SliderId = Guid.NewGuid().ToString(),
                    SliderName = "SliderHome1",
                    SliderUrl1 = "https://drive.google.com/uc?export=download&id=1z9XgREv00FGoCR7zke-NzoNnIBiQYqvM",
                    SliderUrl2 = "https://drive.google.com/uc?export=download&id=15xcKBMdxJeQMTLaQjHh9KbT6ZlKGsaZv",
                    SliderUrl3 = "https://drive.google.com/uc?export=download&id=1q3-Sg09LDSshwDBe3WVOTlcx0QmP-0tT",
                    SliderUrl4 = "",
                    SliderUrl5 = ""
                });


            // Table Categories-Home

            builder.Entity<CategoriesHome>().HasData(
                new CategoriesHome()
                {
                    CategoriesHomeId = Guid.NewGuid().ToString(),
                    CategoriesHomeName ="CategoriesHome1",
                    CategoriesHomeUrl1 = "https://drive.google.com/uc?export=download&id=1VYldlvs2ROaTJPsE2eIkMXktOBbLHy9f",
                    CategoriesHomeUrl2 = "https://drive.google.com/uc?export=download&id=1j0uME7aL_KXY1df6AN0p8psngFdiX73K",
                    CategoriesHomeUrl3 = "https://drive.google.com/uc?export=download&id=1Gm-TZ2nqI5eUAU0O45cgeay38AS0OxiI",
                    CategoriesHomeUrl4 = "https://drive.google.com/uc?export=download&id=1g4QK9WF2e9aXHpJCUXK0-1H6j6kC7r5L",
                    CategoriesHomeUrl5 = "https://drive.google.com/uc?export=download&id=14ybZRAMDRY_OhMcCXXzVtjeyHhnaKn5l",
                    CategoriesHomeUrl6 = "https://drive.google.com/uc?export=download&id=1vOIH3t8uhGxNKF7w76kViqlmlQH1-6YU",
                    CategoriesHomeUrl7 = "https://drive.google.com/uc?export=download&id=18tu3dYEqUmKx5bJL_hjSN467GO3cbaQE",
                    CategoriesHomeUrl8 = "https://drive.google.com/uc?export=download&id=1EEMOiZF6E5sKIFGntEySd0SVvZmvFe78"
                });


            // Table Feature-Home

            builder.Entity<FeatureHome>().HasData(
                new FeatureHome()
                {
                    FeatureHomeId = Guid.NewGuid().ToString(),
                    FeatureHomeName = "FeatureHome1",
                    FeatureHomeTitle1 = "Secure Payment",
                    FeatureHomeTitle2 = "Worldwide Delivery",
                    FeatureHomeTitle3 = "90 Days Return",
                    FeatureHomeTitle4 = "24/7 Support",
                    FeatureHomeDesription1 = "Lorem ipsum dolor sit amet consectetur elit",
                    FeatureHomeDesription2 = "Lorem ipsum dolor sit amet consectetur elit",
                    FeatureHomeDesription3 = "Lorem ipsum dolor sit amet consectetur elit",
                    FeatureHomeDesription4 = "Lorem ipsum dolor sit amet consectetur elit"
                });


            // Table Customer-Home

            builder.Entity<CustomerHome>().HasData(
                new CustomerHome()
                {
                    CustomerHomeId = Guid.NewGuid().ToString(),
                    CustomerHomeName = "FeatureHome1",
                    CustomerHome_CImg = "https://drive.google.com/uc?export=download&id=12BEbKPhMNT6Gl31Wgzo1XNA6kf5zCtYm",
                    CustomerHome_CName = "Customer 1",
                    CustomerHome_CWork = "Profession",
                    CustomerHome_CStar = 5,
                    CustomerHome_CDesription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur vitae nunc eget leo finibus luctus et vitae lorem"
                },
                new CustomerHome()
                {
                    CustomerHomeId = Guid.NewGuid().ToString(),
                    CustomerHomeName = "FeatureHome2",
                    CustomerHome_CImg = "https://drive.google.com/uc?export=download&id=12xlH3LvPKtXEUTRFdETM7SGvCnjU9S-c",
                    CustomerHome_CName = "Customer 2",
                    CustomerHome_CWork = "Profession",
                    CustomerHome_CStar = 5,
                    CustomerHome_CDesription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur vitae nunc eget leo finibus luctus et vitae lorem"
                },
                new CustomerHome()
                {
                    CustomerHomeId = Guid.NewGuid().ToString(),
                    CustomerHomeName = "FeatureHome3",
                    CustomerHome_CImg = "https://drive.google.com/uc?export=download&id=1-VztC3V4O7HyIdetuemHMO61M5up94uD",
                    CustomerHome_CName = "Customer 3",
                    CustomerHome_CWork = "Profession",
                    CustomerHome_CStar = 5,
                    CustomerHome_CDesription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur vitae nunc eget leo finibus luctus et vitae lorem"
                });

        }


    }   
}
