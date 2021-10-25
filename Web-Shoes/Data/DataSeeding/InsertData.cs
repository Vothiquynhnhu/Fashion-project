using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;

namespace Web_Shoes.Data.DataSeeding
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
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1qGc4cXF4az9X2evToVj0x0Ceu2qmQYnN",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1iViLlxnkxISB8wMdMjka0ILlfWmvple8",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1EPqJakj7EBtmPHZO0gf_wo8HPgUa75Zf",
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
                    pd_NameImg4 = "4"


                },

                new Products()
                {
                    pd_Id = 2,
                    pd_Name = "OFF-WHITE ARROWS PRINT SHORT-SLEEVE T-SHIRT - BLACK/GREY SS21",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1iViLlxnkxISB8wMdMjka0ILlfWmvple8",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1UZzX_yVVgDsemltdOZvX_943pfU6cXoO",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1VLOsewsM_8-8m-Ko2ZvsvDaa01_DGlMX",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 3,
                    pd_Name = "OFF-WHITE ARROWS PRINT SHORT-SLEEVE T-SHIRT - WHITE/BLUE SS21",
                    pd_Description = "White, cotton, signature arrow pattern, logo print on chest, round neck, short sleeves, straight border",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1EPqJakj7EBtmPHZO0gf_wo8HPgUa75Zf",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1fkx0O2cIJ5DrL60l7EJu0QX-xISIVmNa",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1TRmzvuN91iCLO1SRXtVMxJwuRQmHnpij",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 4,
                    pd_Name = "ANDREA MARTIN Grey Astronaut Mesh Shirt",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1rOilu5Z4w41A7tx3kkd9l5PSvPfMnfBT",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1mc_eKkp4OscemgzZBGZcCFuEWznZS-pW",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1YnUToorFthY05S17uSQIRnXcUBiJLVH8",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 5,
                    pd_Name = "BURBERRY SHIRT",
                    pd_Description = "- The shirt is made of breathable cotton fabric, good sweat absorption, bringing comfort to the wearer. Beautiful standard shirt form, delicate seams meticulous detail to satisfy even fastidious customers.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1QhQ9e5DmIcqaXPy0RBNrvIAMgbv_YWqs",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1JWK25M-KEkvqsxeuiNjFm4nlPEiHIoQ4",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1Q-KWkHbFDVa2MHEZOxmNiaBbu1IffhGv",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 6,
                    pd_Name = "ADLV SHIRT",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1e_zKMaR3x86zIuTaEWYew7cyLeT-VWni",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=19u835hxFv_7E5ktACy9XfbPMxYifZ6G_",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1o4tsocSZxePog0y6NQg6aLCq-xDx5BYp",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 7,
                    pd_Name = "BURBERRY SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1nD8Fl62ptV1LXUZpM3cW-rECv4cXMHEn",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1rURWs71KvJDQ81go7rA-m0N2U7iktBJt",
                    pd_Img3 = "",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 8,
                    pd_Name = "BURBERRY MONOGRAM MOTIF STRETCH COTTON POPLIN SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1RmcA-LwkzPlAdUMb-ZtvuY1j8lGzW3HU",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1a6tJReOu3wtzJ_1BSdlR3L6d-2KPske7",
                    pd_Img3 = "",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 9,
                    pd_Name = "THOM BROWN SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1Ry38U-_ZzzGsnci5mqHObvi8tgoc6Trz",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1R_a3f_050dqsgbQLz23FQxPfVForPLkc",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1J5Yim8sYRqELe9Imzj4mrun7uytnQm6R",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 10,
                    pd_Name = "BURBERRY SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1UUIDx-uORgXTIJsIytWO957naKtGAq3A",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1QLfLZv4TN2ugOZM375L9ZIwNmkdUKiy5",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1uajOerRRnV9eB7BS0UnIVXcfuPnscZyg",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 11,
                    pd_Name = "BURBERRY SHIRT RED",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1VjacENWRQeseioMaQFhcWdmOlvsIcPht",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1tQlJGdeQceNTTaDzkAVKyycgylDhMio8",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=158cFi3wOuNmrPD5woibSuVT-YT_RCRpw",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1Sb1zUw0A3ZmvBJ_ZNkqpHpKrqYrnhk0M",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 12,
                    pd_Name = "BURBERRY SHIRT LIGHT BROWN",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1ZKZYlg_rA6EZ7SdsVe4GbI0tP18uG67Z",
                    pd_Img2 = "",
                    pd_Img3 = "",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 13,
                    pd_Name = "BURBERRY SHIRT LIGHT BROWN",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1OUfVp1RZhpwhZAch5daeLszb0HzccbtJ",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1ahvRu6z7hwYYX1I10K3Rjx6kMyH2Vi9E",
                    pd_Img3 = "",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 14,
                    pd_Name = "THOM BROWNE WHITE SHORT SLEEVE SHIRT",
                    pd_Description = "Endless styling opportunities are in store with this Thom Browne shirt. Made from breathable cotton, this piece is both cool and comfortable. Talk about no trouble. Features a button-down collar, front button closure, open front pockets, curved hemline, front logo patch and tricolor stripe detail with buttons on both sleeves",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1MLh7rMo4ZLlvjGL9lVwptz1RflsvvFsn",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1rU7uI2Wu25u8LMSBkJ9oQLYyRwbCLPOn",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1LjscRUDgfVKmg0PDX5oTChoiNG0kukg3",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 15,
                    pd_Name = "GUCCI GG STRETCH COTTON POLO - DARK GREEN",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1D3qVLRk7-M8PBVm2m0ZwOAgp4kKafvOD",
                    pd_Img2 = "",
                    pd_Img3 = "",
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
                    pd_NameImg4 = "4"

                },



                // Women
                new Products()
                {
                    pd_Id = 16,
                    pd_Name = "MOSCHINO T-SHIRT GOLD LOGO WITH PIG",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1WLz6y8DGD6FVXhV-bP_EdjwlnF1TXRUS",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1CcTPQpg8PlEyIX5iKI8kN4aHBsyl9FwU",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1bF29kqD_1ajfzX6kny82Q9SJw9rS8rt4",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 17,
                    pd_Name = "MOSCHINO TEE WARRIOR",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1-QV_gSFzdfy-qRTPLgbWwTD2plYwteNk",
                    pd_Img2 = "",
                    pd_Img3 = "",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 18,
                    pd_Name = "MOSCHINO TEE DOLLARS",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1BqGUuj-7G4MDgK-k38SML_wLuNmsxV4t",
                    pd_Img2 = "",
                    pd_Img3 = "",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 19,
                    pd_Name = "MOSCHINO T-SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1OcAaWtM9osemCa3B4TWG2USDDVnjRM7X",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1pjpGm7aE5kZ2pCaQDAGox00t9YK02uoc",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1mm5fCb2D1d9IJkSEQ_KId3e5K57T0bXO",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 20,
                    pd_Name = "MOSCHINO T-SHIRT",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1b4zWMxw2fSXDmTZsZfI5UGRW4ujKo1rN",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1JR9ts1KgrL0abi8u-3P60isz-alhrvo_",
                    pd_Img3 = "",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 21,
                    pd_Name = "MOSCHINO T-SHIRT COUTURE",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1oL6TkiejPN42yqbWEv8xN-Ckah67S0xW",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1JdEfzri9AU-QBrlcVvVtA733KV95fo89",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=17OhvAH_HTfZFMvQYwolkdSwGS7To7s1f",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 22,
                    pd_Name = "SUPREME SPIRAL T-SHIRT - WHITE",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1xi9IyKns4dFZD1Fyxpk4i0HkHdfkKU78",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1Ka9RyvnJxZRkeeDuM06N0MvfScwfDln8",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1IsdUB3ikPiRnKkZSKjdnG9vJS6zMESIX",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 23,
                    pd_Name = "SUPREME SPIRAL T-SHIRT - BLACK",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1bDO25ILHq2cvHXn5S1fUzRhSejVCJ-8n",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1Jmco4XQmd82c7Lng1WJe66crfAYMOBjD",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1BEODWmyDSlBEnltTR4NLBJ3KXoW6RUvS",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 24,
                    pd_Name = "SUPREME CROSS BOX LOGO T-SHIRT - NAVY",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1WlhWQzqgCVnlI9XyNtRD8iJ0O-2Oa25L",
                    pd_Img2 = "",
                    pd_Img3 = "",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 25,
                    pd_Name = "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK DONUTS 1",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1uBO0fPafsG1P5vmtwvgkOrcypX6H4rDY",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1BlxKN-HjkTHzIQW8AwUpKCSGdf22cJXj",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1gxUlGv7LqXuQX9uyhmbL6DW3q9QkjEqv",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1izxagkrKqxpOMU7SsiGLi3agg8OvuQGX",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 26,
                    pd_Name = "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK ASTRONAUT",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1w8KaiMGTvWcxpJMfalYcFEN_yG6Awk-9",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1u0R9N991JjD80tnr8ASmRiZ8kt8_D2T_",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1yLUSschFEI0auLqrZ8qnCkO8L534TDAp",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1-E6bVLQEKaq2fkR2dd96v8mWtFq_tzfi",
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
                    pd_NameImg4 = "4"
                },

                new Products()
                {
                    pd_Id = 27,
                    pd_Name = "ADLV ASTRONAUT TRIO SHORT SLEEVE T-SHIRT - BLACK",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1c8sJrSezckX9Vm0p387ikGFsU1Tuv87r",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1yMULMDGga8_c2lBh6j2KrMt9VN9N90hV",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1GUQbvk2Pa1eS3tKaxCuM_4Ow-hKPxE_w",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1GvhlYo8s5HMGZ0flnPnsVJ6ZRu4nEAkb",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 28,
                    pd_Name = "ADLV RAINBOW CLOUD LOGO SHORT SLEEVE T-SHIRT BLACK",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1stJaTkCT3ZXMWE_Ph_d5TLf97pmMhIF6",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1MyfOcOXt3aCd3Qv16_grwbVKYvKQf-ps",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1GJVPqfAWR-PiI_Eg5A01QxSfXYubq41F",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1mtlkFQFl32HILbTC5snWntWsOcTMiPji",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 29,
                    pd_Name = "ADLV TEDDY BEAR SHORT SLEEVE T-SHIRT BLACK",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1DcgjPlR0vCPGXVp_AZYZdaEobjRznKOu",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1NDYqoXAwGNqTZPfFjshzXhQ6SohCIMg4",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=11oUK_-D0E3voLuD37_t_PmqSGUCAL23h",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1eaUpzTFbUzs3BsTRbySKqxN1KiVhtgkT",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 30,
                    pd_Name = "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK RABBIT",
                    pd_Description = "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1rLOrHjbc_a6lW5Q6MKx9uCNN6SJelkQf",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1GfDcGW2aeOjsGIUkojoeCxun4G_mVRZu",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1vcfWHY2hXs4rlG_OBcp2FkJrMi9jWL3r",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1eAjIfM9bS2tqUnouKq1sle1bGRsBZWpc",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 31,
                    pd_Name = "MCM BROWN CROSSBODY BAG",
                    pd_Description = "",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1cus6PlFMcV6Qpye0-Ff0TLabYoWnJIht",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1SpXL_PswMgBR8YMhIYCnPp_wQ6LPdXAC",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1jtfRGI7aS0DA7nWQdyPmJvFz3tE52G4o",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1p-rhtAO9y8x54khE-S4xyrjCM9flxtwM",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "MCM",
                    pd_Style = "Crossbody bag",
                    pd_Color = "Brown",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 32,
                    pd_Name = "Prada Cleo Brushed Leather Shoulder Bag",
                    pd_Description = "The Prada Cleo bag with sophisticated allure reinterprets an iconic design of the brand from the 1990's. Sleek curved lines emphasized by the particular construction rounded on the bottom and sides give this hobo bag a soft, light look. Brushed leather, a modern and versatile material that is distinctive in Prada collections, is ideal for creating always new combinations and contrasts. The enamel triangle logo decorates the silhouette.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1fhdHU_V5FYVQ7i5ZefEktABB5JqzL01H",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=12bTJvLOAH-_rC0NhjZc1NU4S7sYiFJof",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1XtXVuJG4FIKd-0UU-J288yUQHH-cxMaO",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1-r_5xt9-sQSZYr78VfwhL9Tbqwemlg3J",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Prada",
                    pd_Style = "Bag",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 33,
                    pd_Name = "BURBERRY MINI LOGO GRAPHIC CANVAS AND LEATHER POCKET BAG",
                    pd_Description = "An archive-inspired tote in canvas and topstitched leather, featuring a front pocket stamped with our Horseferry print. Carry by the reinforced top handles or detachable shoulder strap.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1FivY1-HqVnegDBV8kcv7wgdHnU4AkWem",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=19RsYsZymH7kMSH-71UzpleonRtyaiw_J",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1gUUl3WOTr_C5u5V0rcJdNCL6imqtbg45",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1YoUX47gEGBKEkuO9_ACjmdhF1rYvi0c9",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "BURBERRY",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 34,
                    pd_Name = "MCM MINI COGNAC PATRICIA VISETOS CROSSBODY | MWKBSPA01CO001",
                    pd_Description = "Infused with the heritage emblem, the front pocket of the Patricia backpack is protected with the famous Laurel Buckle. The detachable leather strap allows you to turn the x-mini accessory into an elegant handbag or crossbody bag.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1TWAmegqZrDSIBfFP5m-g5F2_Rj3NsS9I",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1FF5-HdgiPEqmYMpGGoO-C_MasTRqVLCi",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1S8oVliKLqeafD2QLbiRcKrrpf6kA5Hbx",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1zL07pOXYCk80y4n-wGIHqm6y7IsuGbhn",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "MCM",
                    pd_Style = "Bag",
                    pd_Color = "Brown",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 35,
                    pd_Name = "GUCCI BELT BAG FAKE LOGO WHITE",
                    pd_Description = "Combine both style and practicality with this Gucci Fake logo bum bag. Constructed with an adjustable fabric buckle waistband, this compact has a zip compartment and is finished with the brand's signature imitation logo details embroidered on the front.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=12niwGccl8KfuoLkrvDEpsTZ34otlOLc-",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1uqem4eQawaG2OGwvBHN20_gt3yMEniCR",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1rTroGFVd7WnKRuPVCy4dZrOsTSBMA1rI",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1Qtq4NUk_dtuEOO7zDfvU6RDmb_-1Si-y",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Gucci",
                    pd_Style = "",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 36,
                    pd_Name = "BURBERRY BAG",
                    pd_Description = "What do your phone, your wallet, an old lipstick and some emergency snacks have in common? They all belong in this crossbody bag from Burberry - with a Horseferry print to the front and a spacious body, this bag fits all your essentials and more. We've got you covered. ",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=11wRP1ACgpE4kP1xD9ypWMnjQd1F6aTqX",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=14_iUyL97JjXYgWADSmlRs-J0VVvVWLL1",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1dAXTIpBYyksPxIi3bMlH8fTKYALTv6Sv",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1KzjLV_HAKknlRzCg3CHKb69aweVUorv5",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "Burberry",
                    pd_Style = "Bag",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 37,
                    pd_Name = "Marc Jacobs Tie Dye Snapshot Cross Body Bag - Pink Multi",
                    pd_Description = "Marc Jacobs’ iconic Snapshot bag has been reimagined with a vibrant tie-dye print and a matching cross-body strap. Crafted from saffiano leather, the compact style has two zipped sections and slip pockets to keep your daily essentials organised. Silver-tone metal hardware and co-ordinating ‘Double J’ hardware completes the bold style.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=1N4UQ_qU7D0jwof4cPG83XujEdGDh7s-p",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1gZFceh7UvwzamS0f-T997J00rvjnDCC_",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1rxWh70yUyRl4W-1GahDplUxO50FOaWk5",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1s0noMO6Z2IFL8jN7JfEgw54pBAqavXjn",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "MARC JACOBS",
                    pd_Style = "Bag",
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
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 38,
                    pd_Name = "Marc Jacobs Tie Dye Snapshot Cross Body Bag - Blue Multi",
                    pd_Description = "Marc Jacobs’ iconic Snapshot bag has been reimagined with a vibrant tie-dye print and a matching cross-body strap. Crafted from saffiano leather, the compact style has two zipped sections and slip pockets to keep your daily essentials organised. Silver-tone metal hardware and co-ordinating ‘Double J’ hardware completes the bold style.",
                    pd_Price = 100,
                    pd_ReducePrice = 10,
                    pd_Img1 = "https://drive.google.com/uc?export=download&id=17Eq6odE_bU2_vEaSyLzxKmIzlSAvfXe2",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1v1RAixoCfJhNItZBYDLVCypdKY5qbhd0",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1jycki4ONFJrzcgEuBUX6O3ZR_jIVJ9P8",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1F56uErxN3w3BK51w4xe-aODnio_dna3l",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "MARC JACOBS",
                    pd_Style = "Bag",
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
                    pd_NameImg4 = "4"

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
                    Name ="staff",
                    Description = "Staff"
                },
                new AppRole()
                {
                    Id = IdRoleAdmin,
                    Name = "admin",
                    Description = "admin"
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
                    pic_CategoriesId = 2,
                    pic_productId = 11
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 12
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 13
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 14
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
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
                    pic_CategoriesId = 1,
                    pic_productId = 21
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 22
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 23
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 24
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 25
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 26
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 27
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 29
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 30
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 31
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 32
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 33
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 34
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 35
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 36
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 37
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 5,
                    pic_productId = 38
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = 3
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = 31
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = 32
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = 24
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 4,
                    pic_productId = 34
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = 29
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = 26
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = 12
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 4,
                    pic_productId = 13
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 4,
                    pic_productId = 16
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 4,
                    pic_productId = 6
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 4,
                    pic_productId = 29
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = 19
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 4,
                    pic_productId = 37
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
                    couponPrice = 10
                },
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode = "code50",
                    couponPrice = 50
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


        }    
                
               
    }   
}
