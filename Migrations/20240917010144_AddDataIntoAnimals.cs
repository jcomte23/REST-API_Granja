using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace REST_API_Granja.Migrations
{
    /// <inheritdoc />
    public partial class AddDataIntoAnimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "animals",
                columns: new[] { "id", "animal_type_id", "birth_date", "description", "name", "weight" },
                values: new object[,]
                {
                    { 1, 4, new DateOnly(2022, 1, 5), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ollie", 293.7973014404393 },
                    { 2, 1, new DateOnly(2024, 5, 18), "The Football Is Good For Training And Recreational Purposes", "Amanda", 332.17163856618697 },
                    { 3, 3, new DateOnly(2024, 7, 10), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Harvey", 374.71158187741366 },
                    { 4, 4, new DateOnly(2023, 5, 21), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Larry", 356.00452392771984 },
                    { 5, 4, new DateOnly(2024, 7, 11), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "John", 247.12386811282988 },
                    { 6, 4, new DateOnly(2022, 9, 23), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Hugo", 337.32125174467268 },
                    { 7, 2, new DateOnly(2022, 11, 28), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Nick", 43.105309543220663 },
                    { 8, 3, new DateOnly(2024, 8, 27), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Muriel", 185.87962608364876 },
                    { 9, 3, new DateOnly(2020, 4, 17), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Matt", 159.57788283744219 },
                    { 10, 5, new DateOnly(2022, 6, 6), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Jason", 296.45683235562802 },
                    { 11, 1, new DateOnly(2023, 7, 14), "The Football Is Good For Training And Recreational Purposes", "Andre", 210.54372118298562 },
                    { 12, 1, new DateOnly(2024, 1, 8), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Chester", 139.94336586356246 },
                    { 13, 5, new DateOnly(2024, 9, 14), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Philip", 21.098943145960352 },
                    { 14, 3, new DateOnly(2023, 10, 27), "The Football Is Good For Training And Recreational Purposes", "Ruben", 283.2364211557134 },
                    { 15, 1, new DateOnly(2019, 12, 22), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Jacqueline", 213.64281958575819 },
                    { 16, 1, new DateOnly(2021, 7, 14), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Mandy", 31.200976668720891 },
                    { 17, 1, new DateOnly(2024, 8, 10), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Megan", 93.285013891497471 },
                    { 18, 5, new DateOnly(2020, 11, 28), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Alicia", 277.35074740780624 },
                    { 19, 5, new DateOnly(2022, 4, 11), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Lee", 90.796512734094463 },
                    { 20, 3, new DateOnly(2020, 3, 1), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Adrienne", 341.36072230914334 },
                    { 21, 4, new DateOnly(2021, 10, 20), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Kristy", 413.86332798547784 },
                    { 22, 1, new DateOnly(2023, 6, 29), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Kim", 234.29052886978755 },
                    { 23, 5, new DateOnly(2020, 6, 17), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Cindy", 106.82825546323501 },
                    { 24, 6, new DateOnly(2023, 5, 6), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Alyssa", 13.718521768423905 },
                    { 25, 2, new DateOnly(2021, 5, 14), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Irene", 155.45105690389332 },
                    { 26, 5, new DateOnly(2024, 9, 15), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ervin", 361.84834718337493 },
                    { 27, 6, new DateOnly(2023, 5, 2), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Claudia", 46.607295115430496 },
                    { 28, 4, new DateOnly(2019, 11, 1), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tami", 437.94569997075723 },
                    { 29, 3, new DateOnly(2022, 7, 29), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Pat", 413.59978226700684 },
                    { 30, 5, new DateOnly(2023, 9, 10), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Nettie", 357.27053250944164 },
                    { 31, 1, new DateOnly(2024, 6, 19), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Delores", 493.66253488053883 },
                    { 32, 6, new DateOnly(2023, 3, 25), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Francis", 434.99477921699207 },
                    { 33, 6, new DateOnly(2020, 3, 19), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Wesley", 452.2462752040326 },
                    { 34, 5, new DateOnly(2020, 1, 2), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ann", 152.25400880504952 },
                    { 35, 4, new DateOnly(2023, 7, 16), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rudy", 181.09067889949981 },
                    { 36, 6, new DateOnly(2021, 7, 8), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Spencer", 490.95193634443223 },
                    { 37, 2, new DateOnly(2019, 10, 12), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Marianne", 107.0417348387025 },
                    { 38, 6, new DateOnly(2021, 7, 26), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ben", 165.1215694884491 },
                    { 39, 6, new DateOnly(2020, 3, 10), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Angelo", 155.69868437644652 },
                    { 40, 3, new DateOnly(2021, 2, 14), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Stacy", 106.91893422298362 },
                    { 41, 2, new DateOnly(2021, 5, 3), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Doris", 139.07537468862674 },
                    { 42, 3, new DateOnly(2022, 4, 14), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Edmond", 436.6806781209965 },
                    { 43, 6, new DateOnly(2023, 10, 24), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Terri", 453.07952353716291 },
                    { 44, 3, new DateOnly(2020, 11, 28), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Hubert", 340.83078230458153 },
                    { 45, 3, new DateOnly(2020, 8, 24), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gail", 33.533899742361939 },
                    { 46, 3, new DateOnly(2021, 6, 5), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Cora", 71.683362006218644 },
                    { 47, 6, new DateOnly(2021, 4, 13), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Blanca", 57.38429582765729 },
                    { 48, 4, new DateOnly(2021, 9, 12), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Evelyn", 189.25031721544752 },
                    { 49, 4, new DateOnly(2024, 3, 14), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Barry", 33.186933032504371 },
                    { 50, 5, new DateOnly(2024, 6, 10), "The Football Is Good For Training And Recreational Purposes", "Katherine", 443.56203472044956 },
                    { 51, 2, new DateOnly(2021, 9, 23), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Alan", 70.576470401986825 },
                    { 52, 2, new DateOnly(2021, 1, 28), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Jerome", 472.38455528456842 },
                    { 53, 6, new DateOnly(2023, 10, 3), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Terry", 456.65343463736957 },
                    { 54, 4, new DateOnly(2023, 6, 8), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Lynne", 250.46686030756209 },
                    { 55, 6, new DateOnly(2023, 2, 8), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Glen", 76.837791496312533 },
                    { 56, 6, new DateOnly(2024, 1, 26), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rachel", 135.64367119319556 },
                    { 57, 2, new DateOnly(2021, 10, 12), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Yvette", 11.080546173714456 },
                    { 58, 6, new DateOnly(2022, 12, 1), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Leigh", 421.4746989813645 },
                    { 59, 4, new DateOnly(2022, 8, 9), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Edna", 305.76301728708393 },
                    { 60, 6, new DateOnly(2024, 4, 12), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Emilio", 264.18235832223468 },
                    { 61, 6, new DateOnly(2024, 1, 4), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Claudia", 20.013440664746454 },
                    { 62, 5, new DateOnly(2021, 12, 27), "The Football Is Good For Training And Recreational Purposes", "Felipe", 201.19250251100794 },
                    { 63, 3, new DateOnly(2021, 10, 29), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Emily", 77.162389097345908 },
                    { 64, 5, new DateOnly(2022, 5, 30), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Julia", 384.33708361664378 },
                    { 65, 3, new DateOnly(2020, 1, 6), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Natalie", 343.78291347547207 },
                    { 66, 5, new DateOnly(2022, 6, 30), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Dolores", 334.0107763014575 },
                    { 67, 1, new DateOnly(2019, 11, 11), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gerardo", 476.29008275062745 },
                    { 68, 3, new DateOnly(2021, 4, 25), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rose", 326.8456448315888 },
                    { 69, 5, new DateOnly(2023, 8, 28), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Alyssa", 229.34105522879301 },
                    { 70, 3, new DateOnly(2023, 6, 2), "The Football Is Good For Training And Recreational Purposes", "Fredrick", 24.510554021288783 },
                    { 71, 6, new DateOnly(2021, 9, 30), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Jody", 73.762731480712262 },
                    { 72, 2, new DateOnly(2024, 3, 10), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Forrest", 76.708874915023529 },
                    { 73, 2, new DateOnly(2021, 9, 7), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Abel", 8.8582884767623717 },
                    { 74, 5, new DateOnly(2023, 8, 18), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Jenny", 58.995061097295149 },
                    { 75, 1, new DateOnly(2023, 3, 20), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Jeannette", 221.63005748806518 },
                    { 76, 6, new DateOnly(2020, 12, 25), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Boyd", 163.53868934638223 },
                    { 77, 5, new DateOnly(2024, 7, 27), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tom", 85.738427276724863 },
                    { 78, 2, new DateOnly(2020, 1, 19), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Brandi", 222.79493632218109 },
                    { 79, 3, new DateOnly(2024, 1, 8), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Lori", 242.73220966436793 },
                    { 80, 3, new DateOnly(2023, 7, 8), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Dianne", 193.84468040359982 },
                    { 81, 3, new DateOnly(2024, 8, 26), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Pamela", 118.50788132141994 },
                    { 82, 4, new DateOnly(2021, 12, 23), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Isabel", 421.14557674448878 },
                    { 83, 3, new DateOnly(2023, 5, 7), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Kelly", 356.29468822127006 },
                    { 84, 6, new DateOnly(2022, 2, 1), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Sonya", 370.38787282740776 },
                    { 85, 5, new DateOnly(2019, 10, 20), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Hope", 163.57010049226687 },
                    { 86, 6, new DateOnly(2019, 10, 29), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ebony", 350.28724211631709 },
                    { 87, 6, new DateOnly(2021, 6, 27), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Neal", 262.49627534555395 },
                    { 88, 4, new DateOnly(2024, 7, 12), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Hubert", 382.01056503540565 },
                    { 89, 4, new DateOnly(2022, 4, 23), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Johnnie", 162.096291203025 },
                    { 90, 3, new DateOnly(2022, 11, 25), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ada", 467.86926021921715 },
                    { 91, 5, new DateOnly(2022, 8, 5), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Chelsea", 441.45448922630948 },
                    { 92, 4, new DateOnly(2021, 5, 15), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tony", 385.88963617411321 },
                    { 93, 5, new DateOnly(2023, 3, 17), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Jeannette", 380.88203622143828 },
                    { 94, 5, new DateOnly(2023, 3, 28), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Joanna", 171.12034153960528 },
                    { 95, 4, new DateOnly(2023, 8, 4), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Emanuel", 142.80587049728209 },
                    { 96, 6, new DateOnly(2021, 7, 28), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sean", 388.57509736320782 },
                    { 97, 2, new DateOnly(2021, 7, 17), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Kate", 102.29664670410605 },
                    { 98, 1, new DateOnly(2020, 3, 3), "The Football Is Good For Training And Recreational Purposes", "Leah", 330.02663920455757 },
                    { 99, 2, new DateOnly(2021, 4, 4), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Penny", 322.12188647469674 },
                    { 100, 6, new DateOnly(2024, 2, 7), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Lucas", 130.7458534043846 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 100);
        }
    }
}
