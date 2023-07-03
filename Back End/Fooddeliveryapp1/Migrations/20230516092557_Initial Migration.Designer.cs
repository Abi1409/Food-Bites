﻿// <auto-generated />
using System;
using Fooddeliveryapp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fooddeliveryapp1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230516092557_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fooddeliveryapp1.Models.Cart", b =>
                {
                    b.Property<int>("CartOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartOrderId"));

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CartOrderId");

                    b.HasIndex("ItemID");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Fooddeliveryapp1.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Unitprice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Description = "Its a veg burger",
                            Discount = 5m,
                            ImageUrl = "data:image/jpeg;base64,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",
                            ItemName = "Burger",
                            Unitprice = 150m
                        },
                        new
                        {
                            ItemId = 2,
                            Description = "Its a veg pizza",
                            Discount = 10m,
                            ImageUrl = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUSExQWFhUXGCEcGBgYGhsgIBwgHh4cIBshICEbICkhHyEmICAhIzIiJiosLy8vGyA0OTQuOCkuLywBCgoKDg0OHBAQHDEmICczLjEzMC4wMDMuLC4uMS4uLjEwMS4wLjExLi4wLDAuLi4uLi4uLi4uLi4uLi4uLi4uLv/AABEIALcBEwMBIgACEQEDEQH/xAAcAAACAgMBAQAAAAAAAAAAAAAFBgMEAAIHAQj/xABFEAACAQIEBAMECAUCAwgDAQABAhEDIQAEEjEFQVFhBhMiMnGBkRQjQqGxwdHwB1Ji4fFygjOSohUkU2OywtLTQ3PiFv/EABoBAAIDAQEAAAAAAAAAAAAAAAIDAAEEBQb/xAAyEQACAgEDAgMHAwQDAQAAAAABAgADERIhMQRBEyJRYXGBkaGx8AUUwTLR4fEjQlIz/9oADAMBAAIRAxEAPwBYpZ8Aj1Kee4xdocTiT35RjTIZourSZKuVMRBjnB2xayjG+/8A04YCSMyHaTniRqOj1cxUqCnOhXI0oSCDEAEtFpJJuY3wQp8SSAdf/qwO1meXzWf/AE4toZ5Cf9S3+a4iqFGBITnmEhnl6n/lbtHLpjWvmXhT6yRPIn/239+Kr2Ilbf61/wDhbF5M0jIiCjDqW9QKEMDf1GNwTbtztGCyZW0pZSoWkskSJnTGw5z8MGMtXhQblhtABFxH2TH+ceaOlNdRN28xNMQI+zMnri5lKdRhqGgCYs7G9uar0xWZJA9aodSsojYHTfe3X3bDF7J5w00ZWFTcxCnnHQWxKtGpyFOR1Zx95H64mqVwikVXppUIlBDaSJE+ogXvYbneDimYKMmQDMio8RIBKqzEH0hpgnlqk7Yq5jxRmKzpRbKVaekzUqal0n0kDRBkySN4jFniXHa4CZWlliGY+uqzA01WdxMMzn+UgR3gTbCubjR8J/JcK062ydsQs4EC51AxXXTJ0mRqix6yzW+GJ6FdwPYY3/mX/wCeClMVdRkyf9VQgdh6SB8MbeTU5CD/AL+3bDoMEvm2/wDDYTt60/JsaRVaSEgd6lO07T9ZI/vgpmcsygNUIRY3Z2H3fl3xY8qmiavPZQyyYj1LzEsptfcQe+Ev1NacsIxanbgQBmhMBVMgerU6XPPTpY29+KFTWBZDM8iOf+778HcqKDIJZizAEqrD7gZkf2xa/wCystOnXVB/1C/yXvhY62n/ANQj01g/6xOWg5vBH+4fl2x41FoggzylhhxbglPSStZgF31rt7zbEGa8NV49JpuOmoqfwj78OW5G4aLKMOREytw/WYIFjI1EWP64iegdp1RzE4PZ7IVac66TKP8AeR/zCRgaX5fDd8NEGBqmQa3fmQRH3XxA/DeZK/f+mCtRr7Sfe+KtaQosQCLHUwBvFu1o/cYkkoHhiFY8wK3dTHzF/uxrQ4eoJmrT3G4qfGPRiwxFxpYkm0Nt8Cp/LFSqGJIAj3n/ABgcSSpUyCmQa9ICSYK1v/r54hrZWlH/ABpb/wDW0fMwf+nFqtkKhn03jnq/XAvMUj/SPi364kueNll2FVP+V/zTENbLCx8yn8nt/wBH641qpB5ff+uIBTcnYH/m/JsVJNmyUX8ymfdqkfDTjz6F/wCbTEn+v/4Ym4VkHrVUpLpBdggLMQoLGBJvAxtm+G1qb1KTU4amxVhOxBg77juLbYqXIq/DWBVS6AMJUnWAQdiNSiRYie2HP+GufOTrsv1VQ19KKVqKCDNrtFiTeLyBY4r8T8Q5avw2nTqhPplIeXTCqQwVWBEADSAy2J2mTytVznAqQyFPNqmdR9QVhUWmabE2JR1AhQwIuJM7WnCSQ6kGF/SZW8V5F6+cr1WQKS5BC1QR6fTIOm8xPxxmPMtkKwRQrFRFh5qCJvtFsZhWtP8A0PmJWpYU4TklpUNAE9yTMkgk25nb44tZVyGDD2lIIO8EbWaQfiIxf4Dx80crXp6CfPTSDMaLESSb7HYc42knFfJVEWm5akXLwKdTUwCEe1AFnPabfHG6BNfL1MXMGTJmNyZJ2xbo5fe5kC1wfyxWpsZG8cyCLfDnOLlJgTCyScBbdXUupzgR1PT2XHCDJm0Iq6nJEiNxN/cN7DFjKFXBamGIUSzaQdIAkkwskRfnjM/wR3osKiNom7K3YiJv1xJ4RpmnVzSSKNJ6SrTZbhFWQQVNtiRJm0XnGP8AfVs2gHB9o3j7OhdE18j1BzNMuBWJ+joagBvVclEsb6JEm/8AKItvgw7GpUCCgygKSXbTEyoAB5yJMjaPhgzxTha0aauvqlgDtzG4uOnXFGm63BVLddJMW5CThlNCZ1qST6+sxnbaeUsip+yQQeqgf3H7jFs8PBXSUQiZuq8rg2tvjRCpEjQPdAn7sXMnlvMbQImJM7cumNZ2gzX6Io5L0Mqs/hjT6PeyqOlhj3MlRUNP0SvunafhY42ylOYYANaQosT3M36W364zXdSlYB5J4jq6Wb3SOvQ03YoCTEehbmYEkbnpvbbFBeNlBpp6dXPQoAIG8necU/FOfy/lkV1YMralBcj1XWLRyvPeMA8imazrytBVBIliIERyEEcxftjiX9TdcfIcD2TrdP01SLlx84y8V4xTqq9InU5FhBN7HYxAEbyPjthWr+KCUYN9ZolQGAuQQonbbv0M7YI53whnF1qKitSIkyPUYG17QeuFdOD1TVUtT00ad1U/aMwoMRtv8L8sLCE7PN1CVkgIciE+G8ZqBj5x0JAKhUMkHVf0iSLG5xdzPGFH/BzDAmL3lY6gxAO3uOKPiVjA06iwpwwG5Gr1bXOwteYI54AUM3QL0qdFmqMzAsCQQBPqJIAi04cvSow1DmFc2lgoHP1z6To3CfEtMBPMbW5naX2gCSYGqDuALHF9eJOQSGgi8fZN9pkcv84iyXgmjCursocBtJuBNz0+eBXiPK6S1Gi5BEG20DcWB74z202jnYe+ZFNBJx8c9ozZvjUU9SGxWR1mASLekm8ET2vBwKrLlMyQDFOo4syAjb2pUjTIvNgbb88JNDNV5NENCTOkLN9uYIM/vbBbJrWFQtVUITdEURa1xaY/pm98F+4trOoGUOlpdcczbj/hivQXWv1tKP8AiKdh/UIlfvHfCxUDbkGw/fLHU+F8UqKW1lRsQoIsI3PY/pgbx7wxRzSGtk9K1ftU5hXPPTNg33HtvjsdL16XbNsZyr+levfkTmzs8bR88RGq/Q4mzFNlJVlKlSQQZkHmI64rONzH346EyzStVMbbd/1GIuD8PrZistCkAWewJiAALkmLAAHv0vjSrS3B98E41pFqZFSk/lsuzBgCDebcwe++AbODp5hDGd5e8WeHK+Rqim7K+pdSMp3G1wRIv1wummxOzGOnf4YI57OPWYPXdXIUKsKAFUSYgAxck/HENBEZgNJaTsm5HOLTMdjgU1aRq5kOM7S5k/C2ZqZWpnU0+XReGGoioPZuBp2GocwbHpgVVzmYqVWdi7u3t1GJYtbTc8hFoG/OcdHXxGHWsKqGlSFJaWX4ddVdQQFdqmmSQSSUtqHWDKfw3M0KZY1CoKCyD2mPYfD974B7AFJ5kyRvLXhzgCCjUq5lWBnUjh4CqLtAF2J2F/cMNlPg1SvkaeYozUeoD5CakIpi51VWqOAg3kCTPc45lneJ167E1GIW0UxZRG3x6n/GCPGOMr9Ey+Vo06lFYY5gk+msxaxHUAg/EReMZv27MdVny7CQAd4/1vDNYMdOZyVQfzeXUEnn7JI3kWPLltjMcizTeY7PUOp2MsWJJJ7zjMM/aVegkwJ0fIZdq8U6al3MwIva/OOWD3B/oFKm44hV8p0YhKTuVgbtpE/zG8cxiXwNwc00+m+bRUoWBDKWhdnaVO8AwBM9b4XuK/X13qlSwdyyl1AMW025W5b9cNL+IxVT8fbCAAGTPUcadQNiJFh0tP6YMeHaqLUDysrcBuvK3PrbF6r4ZpvlqXk1TVrOAWUbKDzIBlNBi7GCQbXjCFk8+VZqbiCsgg7iNxGOd1+WdSNwPvO7+lIGodc4P8TolfPqzGmS7Aepnp3kkGFibfK3xwr57MeW4dkNj7DSJHMH3i07+7FDiWdSoUKAUxT9nyzE9Z69Y64X+J58TZzA3m/+cZzWGbI59efhJ0YtBPiDK44O2x74nYWy9TNCnV88eUPVSoINCAEQoaCSxA62k7DFctoco5AMgARN7REjnt3OOd+CqrZhWUV8xSjbQwiOVnUx8MNuS4CA6u+Yq1GBka3WLdl0gx3nHVpS5eSMTg2Y1HHEZFqdv+m3f44gz5qFZV3pEXDpuOliNJBmIIONQWjcaRzAEySI1MDccgIG535QVM/ThgblDf8Al52JBuOvwwzqrlqrJIz7I3pqTbYAJY4fT+jUXqV3NWox1szwGYmBsAALQIA2Hxwt8c47WoVRXoIpZ7GDJBI03A3H6e/FKjxypVrMnku7AwEBNjteJtNxvh1yvhpaU5uqCXAJWiG9IY7A/PHBVXezJ4naIrqXHc9oF4Hwyo48zNKtVjfQzNadzG33YcuGu6AVacBYA8owFAHQxM3327YCZrJ1kBqvV9e5EAL7hAkD3nliofEvkp5dM63O7N7MG9gLGe564bUreJnfER1FSlMgjJjVxQivoiQsXBkGZiLbQemFviOTNKpFMNURU1VBM+WCfSbmYMk2vYnA0eIqySW0spuVurC3IobWAtODHhvj+Vqo9OkpXXqkkSCYuGDGSSNjJBA3G2HPVltRi6rjUAP9RFB8yuzebuCNO09LTghkHo0Fas6qrn+USb7THWNz3wycT41lKanLahrjTCrIQ8gSLD/SMXspwJM3RUGERKuvRpB1FQQJ7bWjYd8LrQiwK06d36gGqLKMcDn/ABAmV8a1qoCqtFFUQJUljbrqHbHmX4vUZiq5ZDUKGWUyAJH83qG9xJnecaeNeFpl6q+TRSmGX16RAJn0+kCLRv3OB2RytdKhqOo8mpT0zqJMEgm38nUyfuw69FKH8M5lG7Aesa8tQpRq85ZuAwYEoQAfUZ9Q5eq469GfhddMwkEKHSNUQQZ2Knob4WeEZAO6KVVoIMQNh7uXf3YF+IM5WpZhqVF9BamBIAkQ7C1iBucLrYruRse0Gzps3hK25+kL+JzUoMWpU1ZT7UQCd7Xnne3MDFTwxxRXUoQ6tqnS0bAXjtzwlcUznlyWdtQgszOQFJ29W+o3/HBDhvGqjLLSYBkiNXIwSvbnv8jjNdSyjxAJ0/BXHhagSOfhGnxpwinm0L0oGZQAwB/xViwP9UbH4dI5VmVAWZOqYK8ojeSd5tEdL46H4T4i1d6yoTp9O6xoAkb7nkAOcGewHxxwRxWqVFpQoOpnDWYEgBo2BJ/c46PR9WWOiz4H+Jx+p6UJnTFHh/Cq+Zfy6NJneJhSNupmw5fdipxPI1MvUahVXTUQ3FugIN+RF/jg3wbOZnKVPOoFA4GmHIKkHcG4/cYizTVM5mfNzuZpUy9mqEppQAbBA2ogbRzJx0Mtqx2mHAxA+QyNauWWijVCiGoVWCQqkBjG53FhftviPKVYIMkEXBBIvyII2jE+YyIDNoqU2AJAZXVSw2kDVqGobg3gwcH/AAp4Dq5xTV1pToIWDVJDEFVkDSDO5H98EZUvcSpnO5NamoNXQwSpg+1F49mRBt2x5kvD+T876EFNSv5bF6rtCUoWZYg2AJAsCb488Ir5WWrNCvpqlvQwOoALsRytN+WNfCOWyVWhnWz7UBUrAtTJqKHWzMdLcxOkR/TBF8c6tWNjLnCj09skR8zSiFEMTsVuDHMHmO/uxEyDY7/1T+4/XBehTqog1qSrWG1juQQOQtihnMssyeXfHRlyr5a9B9+MxJ5I/lJ+J/TGYkk6/wAH4rw1qWYXMVPKWoSAwd0V1CgFqZmLtqMbkQbiMCeDVcuzK+ZFZ6S0wEVQNUAehTJEfr0E4WeF5dPSlRaUEatQQGJFgSRuDYgTE9sdV8C8Eapk66gUFo12MfVKxJEAkiykdARYidjhCVCrJXvD1ZABibksxWoCq2VWklSqADrBIgbSVgkgSAe+F3jHCsxCsEaq8DWb3P2jfvh1ynh2mjFHoqGVpghbGByW097+/DHwpMtUFQVH0sraQCOg3xzeo61fEKVqCRyScCdPpqjWA7MRngAZ2nBs9Xen6alN0PcR8uuBGYzDPYTH44714m4HTKlHUFGFp5jkR0xyHi/hlqdfQvsWgzc+/v8A2wfRdUlrFCuGEd13ilPEDZU/A/GXvA2ShtTxB647LwPKmvTFFK2XNOSzoAWdWAAHMWvvBHfHP/DHDBTW4vHPDOnmUyXy7ijVIgVNAaAYmVO/W/OMdRlbT5eZxcrmXs/nHpOeGIikuwJqKywBCsQyH1CRCyJ9o/ENxHLnLE/SdIUfZG7DsRdhf97YM+G6bs+qrUatUmXqFQCSVAFkEAACNsUeN0nrOBWWYkbmIFiSBe3ISJnHA6vL2lfTnHHqZ2ugXA9/z9kk4DkA7LmEHkMxJmSbHud47Yj8UZyr5wytCqECqNPqMMSJBY2tMySeWBnEOD1AAKVZ9MWpksIHK/MW2PzwFfJh2CVjU1Kb3hv9rEkx75B+/B1hazlv9TdZ0ZsXUG47fm8dvDfEK+ao1KdeoCFby2KAeoQCRqk25SL98eU/ClGlWFZalX1MRoDQq+lm5X5deuLvhrh1AUlSjUNOSSVYAseuxiTvvgxxbw+vlShl5BXe5E7/AA64dliSy8e+c59K4RufdFDi3D0NLVTqlGLquqDALMFIg773nri/U8DtlctUZKhZz6j9n1ciIuAO3TBHgfh+pUKfSAERGLBObmDBPQCZ67bRg/x2uwpmmFIUiCx/DBhsIS/wmawamCIZw+tTFeotCjScVlbS9QqQEBPr1HY7WIJmMdG4TnzTqiTrVlOnSdo9N9iZj8cVeFU1NWrTaGHpIPVTKwfiJ/3Yr0Hqo9SlphncKuoGIBEMDOxUH54z3uWIxN3TVqaznv8An0jtmuGJmWptUVtI29REnuFNxbn3xNxDJ03XQrAEHlyjlb8MUeF5KskDzCQNlmwwM8U598llq2Ypp6yVALAQGJifdzjqBjQg8mMczEw0tkNxxGXKsFcqiAErGoAWPfCtxfL5cZgtmHFIEaS5eBIuIkX32wrcC8QcRy70sxXqGtRqm6OQZEgEiBKsNxyMERzDR4lNLNVKgZwtKkNbMY306VHu3Y8/Z64q4ArzBrJFwI29onNeMZ4UKusgOrXWL6SF0mzf08++JvDtatVqyqQrOoUN7IG0GNzfYbDBnIeD8xmAKvlBafUmGPOZYkqL/wAs74MZB8tlq9Ok7A1YlKNKSBMiSTvzMmOdueA1M9YXE7DtTW7OrZ529p5hj/s6nllpsq3LXLkBSx3M8oAgDpbngnnKtFwaeoMpEFY5Hr1xFn3o56ky02hhYTEHaYj8sD+BcDejqV6isIMDnva/KPdjIyPS2V3B7zCGWxcudx2nM+M8GajXqUVGoKfSStipEjcRMH5jAatw+pqMq8m59PW9+fzw9eOstDLVWYB0N95Q335j5YTHzhNjB5Dbn8cd7prfFrDCcu+vQ5WR1OFVR9h79iMPngavmPLo5BKYpl6jms0AM9IoZ9UWafT/ADQBEYQvp0z6T8h1/HF7gtWs+YprQLirNmWPT1bfYCZn3YY423MVtH/xTlKdDK1stlKWgWp6QDMsQp3kkwd+dsI+f8OUxllb60ZgGHpPTkNJJDIwFoG6te0jlLB/EPNGjSoUy7NqYmSZLimACWJBkSV7k9YIwgZjPFpMnmTt+mMvSq2kt6mXtJlyTKYK6dRiSO/O04MKc1kqrHJZgMxXS1WiupTJkrNRIMED1AfmMK9OuWI3gDt1wQ4ZlqlV1p0kZ3OwUSbfvfGo5xJtNm4JmOdKpPORjzG9fPVaTGnUBV1MMGW4PeRjMDky/LLSZJhIcMhHtBlKkcx7Rnp88FqWaNby6BzlahRE+zrgE3voJYyYB6TPLFrJfXM+YzPnVaSL9c66VN4VFBIC8wNO5HXnc4JxTJ5epmUrfX0GX6sgAao9QEEBlY2UBOY22hh43gyfhlUxpVpAsHuZAsCQYbv17YEtnaiV2UtIJLSsRAuZMm420RMXmbYrvxV/MaolHy6bGyAkhY5Sdz1+OK9LM0mWR7c6pO844Gjw3YOoOT6c++dxl8VUapjx68dsRl4lnGdFGqoIG5JBjtJMDtbCxmeIr56AmZt92NM7xwshndd+nvwmPxBmrBlJseWGdHU7W637ekb1bV1dMUXv68zrNFTAgN8P8YJ0ONZnKyaFFHZ4DCozKAL7QD8u2F3h2aYoLnbr/fErVnvv+P547jAEbzzwODG3wydKa2jUx9kG09B+xgbxms9OoxJ173kmATYMYER/a+D/AAypopi0mByH44h48U+jjyh66rQqzvfc9hc/Ic8eWR9VhIPqfrPQpYKSCw22EXqVf7TndrA3J7C45fAbm04ncUqykGCpEdp3ta4HXtaBM6f/AOOq1B5xrLAGzBhEXO4gAdPjc4q5XNZeiVqVKiSrT6pIPe3Xlyt1xqQagCBnMcb0fLucY4A/mMvDPClSnSUltas2sKTpdYA0xG590dL4PZDjiALThywtD2O8EsG9XzGIsnx6nVotmqXqUwkBlmRMBZsTJ+NsD6+ZWutMV0KnVrJRvUs+yNQjtI25YM4rPl2+05T2mz/6b7/GGEzNTXVNQJIb6gK4JI7ixHX3YGrlc35gdquqkp1GkIJ2uJidiYHXADN0s8KtOqtI1CoIDFV1aYg+za46X32G5fgXE69YT6EWTLa5PeFAgEe/FhxYcsCI016F2IP8St5lI1BXazaNDqAw0XMEq4Dafhb4Yu5Sp5j06UxUCkCoyTbVPpJ56ZEzyxf4pk6IpAMW1kWYzcbHaBefme2KfAc7FDKMSWmRtJJhhvy2OBZdB+/56xKPsVG/p9YI4rl+IZSoDQZXo0oZ3qNGoH2gZJkjeSQb78jtx3xnlaieTVpvUSp6bgBCSNpJn7uWJv4iZyp5a0oGhypMzAIJEGOlmPuHvxylM7VzDGmNWjUFZmCaTJA5QARa0kdY3w8FmHl2H1mmpKtINmSx4xwBxv8AGNVKplk00ssjVa7NCBm1BepE7m255Xw15Dg9Gmgq5h1ruDIpofSrc2P87TzIAFoFpwkVsilMMtKaZgqXG8TcSDM26jtGJOC5iplaVEMUKuZJVV1KBqMEi5k7gnYxIwpfOPaPX7y7+nNLDV332+0fOM1mOXC06jUhqBJAkkH7I2vefhhe8ReBUo01r0K7moILayzF2YgEmDb4D5YduGZGnUiu3raAQvJZ6DYd8L/ifNv5jBCnlupQl1LBT19PTptbcYupnpHmOc/QRWgWvhe28TWzflgPTcIwiGtvYczG9hvyw+5bN1MzRVho1WDnaQTG0WMg/KccxzlPKkvl0FSuVuaghIJkSoAMwbwZtyg4cvA1dzlnY+kgqDO9vST3t1wV6jwzqgI3/JgS3404YfJZPabTImPs3tP688cuLEwdKcr/AFff+q+Ox512rAEjYRcRIPb3Y4jnVqUqtSkfsORzuASAT8IwX6XYCGUcZyIrrUPlY895brKxi1MT/KU5zv6jHx27YlyvEszlixoPS1EaTOg2N7Fb2+WBeUSrUISmjOxNlUMxNjyFzipXdwxBAsY3j8cdRlDDBmCEa9avVZPNzBdgNC65IAlrWWBcm/cX2xf4xwI0aa1GzAltlICk9YAPxgDC1TeGVrCCPtD988N/idPNoUMyhkLKtAJ0zFyFkxa5jGa12WxVBwu8neLbLaTUNt5D9/6f3OCvhjj9TJ1vNpBXJBRlaR6TBMHkZA5Hn1wu16y/zb8wHt8wD8sQkibE/M/nBxoZQwweJYODkR24l4nzNeo1VUoqGiFeiHYAAAS0XNvhtyxmEymbDf54zC/AX0haj6x88O8QrvSbIKV8qqweoQvqhQNiTtIXl+OPPC6KzedUKeXTUsSTbYkb2Eb/ACxv4I4maZNIBNLkMYHqJFguo8oMx1A2wx5zg1bJ5nUopoKhNSmq3Cw2xGkC0iwttG2M3U3Eal93+YONoveLvFFRcscgKStLtpqKRAVvUJge1+7nCXma1RV9DSsbEAx8dxjolPhFTiWZauW8ykracxVQgAFR7IItMRyMTgP494Vl6FWkmWVQdLFwXLE3UDVJO8mLDY4oafKuNyMx6s4GQdpzpszUqSCSQLxyxa4RkXLBmRtB2bSY62O2L1Th6ioCP+G5GvTGoD7YE2mNpx0zxW9JKFJUzK6a7BqdAUxrCBZAZ5m1pMb2xo14IAHMDJfJYxdyVaogjUW2jlHbfF/LZh2dVk3cDlsSMUaiRAB5TuMWeGoRWpmT/wARe/2hjSeIoczpWZqeVTJb7ImO0dOeBPAM0i1UqMhIM6ReESZ59TM+7phjzVNGJRxY4GZXLI3mMDKr6SvSB1jltBPI48r5a2Jzv/ad3+sYI2/MTzxnxSgtBgraVAEkH0jUwtHTnA74XcpwxahDLVg2MuhX1KPSNhpO3pIB9W2+PPEuZo06a0yfrEaVGktJG2/Pvf3Yn4ZxJOIqS3orBdRcECRNvSBocA8zsTjoo4ZNWMfaKNWltOYxcK4/QytCoMwnluGLn/zTaCpO7bD5fBSbxYpYV6mVqUqZaUbXKtfuomOimPwJPjnh/XlakVKbZn0mmIIlaZnTcmJki1pIthXqJnM9Tp5EUDTWmI1VIAUbHYksYMDDdSMnmImc0nVsJ0Ot4vZQtNVG93a9uUAc4wp54KuYXMUqzrTmXpqAN9yCRMdgP0xpn6fkMUrxYgSLkReV53xc8a53IilSTLurVXuChLHRBnUZ5mI2M9gcZfEZlxO2vTUVsi6SdXccS5mshmGVXQvUosCQykWDXBAm5FunuxBQoLQojy6lQarK9vQAQYAaYJt0274i8CZ2poejSDMuoAtDFAL6pYSAdrf1DvDL4j4KGpqrTO6sqgANeC0kmL/4xlatseXOIizTVdpbB7bdxzE/xZVfMjydZVQhZx/MY9AnZZvJ32IwqvxBzTp5ZKDU1VgSYAAHMgruY52+7HSl8JvTRnVzU1jUZ3MbR09xwoZ9axLDRMDkQLb7ESPdfGmq01jS3Ptjq1ou4OAPrJaL+cTJiSbgbcoAb2jy2xXznhiqc0uXpiqzLGov6aQBvAgCT+nfDf4H8NqirmWGqpuBuB7yYJI/Ee7E3E82XqsxgW9KzYkTYd7e/tg6rAnHJi+rZeos0qdlHMZs7U+j5aF9oJAJ5kCOXOcIuT4oEqs9RZCCHZVDaCbyAftfhOCGU8Q1fKKmh5yKwEl5F9wPTDaSDeY27xDVrVFaKWU06vU7PpAYncmCTPzxLxrx+YmKk+GCmM57+yIOZyeYpGooon6w6kZ1uBPpDKp6WsYE4ZOCVq9ClLjS1gVJ5mII3IB6Hrg3T4jXh18lQQLFW1H3XVY+XPC/leHVNZRzDORUqSdgIN221MY+Z6YXa+sYaKKMtgIGN+PWP9HMeZTV9yQAwW9/hjjPjzKgcQrkruyt3uii/eQcdh8PZClSU6JOvYFtQG+2OWfxOpxnzaJpIducsD+GNX6ccxXVgcCAOE8Rq5V/My7eW8FQ0AkSCDAMjbA10EwRPvv8b3/xiU0/3HvwT4L4cq5nUE8tYEjzGCaomylrE/EY6pxMMDQByj5fr+4wf8McfbKsZ9VM+0v54BvlzLCAdMzphhboVkEdwYxqLdMLsrWxdJlRs4t4bTMMa+VqUwr30G0E7kQPjHc4Wcnn2yr1qNSjRqhhoqI99iYKMPUhBvI6D4NviLI5LJUBlagqnONS83zqJZQrOTppuvmR6QsE9JNjAwucW8HZrL5dczVRQjRIn1rq21jlNuZMkTBwqvKeV2yO0IAmL6k/sjGY8+Ax7jRKjEQSCA7KeRViCLzY4aOEcYzWdzaU69UEXCQgASYlpJvttPyws+aNg5HvCd/6MSUswy+pajK3Ijyxf/kuL7YVbWLBxvL9mZ0/jHiJ+FrlcmtFWTyqZr1NKqXAhX0BbF4XcmLre9gv8S+MZSs1JMq1F4nW1NRZVEImvcwWNtt9jhMrcVrV9OsqpSmtJEpBVUKu1jPqMmSI5Yhy2W0Nr1MAxliNMnr9nBgHmSWKVImYv1j3+7vi9xLNV6z0zWKsKS6UgEG4AOqx6dh+VjjGaymhPo7uKjH2B9kR6iwYTHY87bYFgv8A+I/zXt/TgVK2YbHHrICQMZk9Om1zDX6X/wDbiTTUVgwVrX9npf8AlxWUcy9Sfen/ANeJfTHtvMjcrfrsojlzw7Mqdlzd1LydLJMje42B5YV85xdaEU3YprZmhYioLxuNybSPdg/4PzK1MnSLGQF0zPNZS/ywpeLaKNmKamdFNwurTJk3t7vzx5nqadFuTwczvdGwsGkiDONoa7pmEpl6YLalEzuDq3AO0GD0xd8P0EavXzOYUIujTTpbE7TZedhY/HBvgfCVy4ZnSzezqOqJ2tt0vg/w7NgLGYeio3XVAPY9BhwYuvh8SryiMWH3+0EZBgrt5np1KIZrC0yJMdj3viPOZis9TTktJZUGuoCCFk2AkEMbHbbBTiXiaiB5dOslVzfSFLmBzsbAdcAMz4w8sHTQcAgw8hZHOAJIHbEZQi6c7Rf7rWc4z9RAfH8tVj65iam5cmd+cgCPdywO4B4TrZupqp04pFjqf2Qewbf3kCfjtLmKWYrK1crUNJSIkySSbch6T3F8Pfhzji0aCUKv1VQAA6rhe8WBHcfEDBIMc8TZZ+oFagAoz2zGXhOVo5KilGR3gAST0A26AdBgX/ECpNCAXLDZV+1P81iNMTM2xU4hxZa9X6v10YINSY2H2REm/uxrnn8ugSCdMAFjexgbHscOL61Kgbf2nOSptQsY7n+Yo8Y8X5k1agy6aqSONRZSSeRkgiBIiwwfp8boZilRqslKnrWCzKTpN1YTFhPO2EfM8K+khatB9CNKVVMgyh08uoE3x0nwxRyqU0y8epRMNv192+BeutvLwYzDr5sZHsi7xYVsnUKZao1TWsmGMe6xOoARcwe++My/iem1Gpl6lNKNQzq1t6ZO/qix98Xw2+IVpgQaooyI1QJPSO9vuwpcf8IVXptmPNFRrGCPU67GTcAje1rbXwsJoYgHEZrVkBPP3Ma+BZ6i1JdDo1MAAFTIkW3xT8ZcXQaaKQWABdgSCs7CQNzvHTlcY5l4cFUZg0sujAsL6oElfuv1n8jgvUznluyuvlMLsG9Mcpv8L3xLHYNjt84zpKa2s1MeOx2hA5ivT9SGAbldy0bAs0yTtJv+U/h/Mmoa3mIPpDDVo3WIMD4G5HfCwvGwboSyi1x8LneDjbJcWPnI43jSSSRIgkj+/fC7R5CMbzqP01bjxAe22J0/gNQJS0sED2lUbbeJHL345X/EZGq8QbSJ001BNtyWMY6rQrGnRSQR6RuQYtYbe7544ZxriBq57MPuA+nYTCwCATMXB5HGr9NB0zzXWHzE+s2p8NexK+kXa4Hp52N9pPwx0lKVD6KVJIb7KyCrqdINo3USTcbcxsNr+LsieGplKTkOAgZAkNIYGq1hubmR8MLOaq5amnozNU02PpooRPe7CVT8bRvjU9upgMH5TJqCbSk/Do1eVVVUaVP1irK6tiAZKzBgiLdsWuA8KykzmaogmwU7e8xPOLdDinxPjys4GU1U6YUCNMEkE7iTNovN8MXD8sLPVJvcBjqC2iBtIHfFdRcVrGdifnFEyr4p8J06bJUyzAK5GlVU3a2nToU+r3x88a8a8XV8xlhlWegFgCpVAdnqaTuZUBdUAwJ3xV4L4wfKVGptL01c6HXdYNiJHTFzOeJsp/xFq12eZABe03iAQsbWIi2BVmAAdSSODLV8RQbh6D7at30t+nLb4Y9xvnPEFao7OtSqisZC62MYzGvJ9Je0lUTefvbvjzXp2YQf9Z/LBnxDwGvkynn09IcSpBJXuJB3HMfjgO1Zfj3n88NBB4lSXL1NoJJ6BWv0HX7sdgr/AMNss2WXTVqCqsF2MGZiQBKqI66rczjjqZ8AggwewM/MCfvwYTh+cztKtmPMzFSlTANUzpSIFtIgMYgmATFzvijntJD3i7iXDl05PLU1NemYd1FrA6tbkw09QTfA/hvBa1YBl0gTE+6L2Pw+GAioibDSD0EfkMdTzUUMqXpgakosaY5agpKz1uNsY7rGpUKp3PcyE5MR+M8BqZdQ7MGBMenVaxI3O2/ywIcEgCD+/hj1zVc66tarUYmW1NaT/T7IHYAY9FH9x2xrqDBfMcmVHP8AhhxSVrZSpKxDr3DWMe4wf92DvizhA006kszrcDkxWLnnMcr45vw7MnLVqdZZ9B9QABlT7Q/P3gY7BK5mgCjBhZgR3Av+eOZ+oU5GoczpdFfpIHaLy8YZFDGoZZVQLpBuJJIB6Bp5XAvikMzlAmtaxqVWa9iCsH1aiwkjoRAPLrgb4xbyatJyPSqwbmLEzZbmbbdMLX0xqr1CiWIBgSBcmJEnSOUb2+WcVA0gnnaa6VW3qfMPLvCHGuKoM9NH2m9BCqZIgXGkzM87zGGzwvLEnNBmAHopRGkyCDUkTOx09rydl7IZClR+schq1QGH3CG/pvv12Gx7YJUuPVK1dcusKwIDkzquYOkG1v5jNuWGMAwBHaMZdJanHJ27Qp4z8XlCMpQQMYDVAyFpM+kQ25JUkyREDFDLZ88QQ+Yq08xRYFyJAZGnkSYMgiL3HSMN/Hv4f064pvSqeVUQRMagw3gibmZv3OB+V8OUMqGBrqarsNXmEKTEkQOk/j8MMtGhQDyfvOchRjgnbO8srnqdOkBTQQg9Xf8AfXBT6ZSqUmBOkFYMiOWFyvVQlqdKWLemIIAmQSTsfhOwxay3DTUpzmAUVTMIwuB1jlzxm1upwN50GSorkGUOF5PLplWu0tVZhqN5sPcBbaw54hSs7K7+VsQCwYRJIAI5x2xZ4txbKU6PoWDTMEhZ1GYUHkZPU2wHqeJazUyXpUvJaQyqrKT10uTDHfcCe2GVqbPMe0S1+hCi5yfpGrIcOpZjy2r/AFh1Ai0gEH+brabcsbcWoZtw9HLNTFM29SyR1g/2xT4QRSWC2nWAyPMSDzjvucSUc1UydQiabBjMmZMi15jfngMbYb13iKRrHl59DM4JwpssZzDa3DEjSDB3mANvdfAbj2fpZrUPJlrqytBAZbdJGw6GRgxxXxf5KXK+aZjbSCdtyPlOEXKPWaoWhlBRfNqkghmJ9TKD1EDfeTaMOCBh5eI4F621HmDMnwg6mSmmlt/K9TKd9mB1Dub88NfhfhiUageuj02UGFdfRfYhx6Z/WMEPCeQXzvOsKVAX07ExsSd4Bk9474dkYVoYQAdh26wf3c4Vfvwd/vGr1bqhTt+bRf4lxBDSdgQAJvINh8ccG4XWfV5oYKxfWCDcGZBF5kHHT/4qLRop5OXQCvX9DQBEG5i0g+617zjnOZ4JXo01bVK7SDsfiDjb0SGtcNzOb1LazleJZzDrEgpqkQfx574GuqyT9XJ52/XENSq43J5dP0xRq5p+RON8xx94ZkshTy1PNVMzTOZDyMtoVwwDEBGj1DVG8wN74o8ezjo1F1cRoJUGIvAuJE272wqUWqvCqrOzGABJJJ2AAuT2GDvjamtJ6WXpVC/lUl82SCVrGfNWQB7JAEcrzfGeyrVYrHjf6yY3gupUZiWLKTzPp3+GINf+n/pxp5VU0xUE6dWidQu0TEEztziNsEvFK0hURssrrTNNA2oyPMA9ZHqMA7wTzPuw7YS4M1t1X7v0xmKWo49xJU6D4h8WZrPsoqqqU09lEk3IuxJ7TbvgKzA/ZxOQFF7nt8Rz/f5nOJ+H0GQo5pWC1FB8+mx9R11XWkwHIFVNugnEVQgwJZJPMW2HuGDfhriubpecMqjVQ9JlqU9DOhDCAzBdoJmfhscAs1QqKRqBWRI1CJ3uO2L/AAHPZihVD0K5pMfSXAFlJEzIIgROx2xcktcJdxUVUYoX+rJnk1jPbr7sdKzuaFOmlB5IprpJizwINuhH54oeIsnn6i0mSnk/Mpp5n0jLn1sSLjSQLMG1epSDcgiYwjVs7mqtdKlapJpmFCDSBe9uZIEfE4x9RQ9xGDsJJD9NC0zKxqI9rddMyASbDqe2NcpxBKhKq8m5tN43jbbFbOZGq1IpUBWoGkhgRvJIIN7g4j4dlKpqq7hFCgqqr3tjYMiSFyGPM4bf4fcUNL/u9VoBM0vjuPvkDodrYzJcJp06JNRAzsvpJJBU8iItfaDhUzYZX1BwrrdfTtvHO/TGXxq7wVXn2wq30tmO3j3hdY6Koh6UaSGm25Yjrt88K+S4XXdgqUjRy6MGYGCzEbEnfflPLtGOieEuP08/lwj+mosB1BgqR98HcHp8saZThLUKtRizOGYGWuABMCNrH8b45lmqo4xt2987fTWrgt32+MRM7TZyy6GAkfzcvwg4OeE/CzVKq164OhDI9KgsfeBJHx7X5O3mLVIC0gWkXKx8b4NmqT6QkAe6+GUoDwYzquvLrjQM+vcSoeM6UgKbC4AJIB2mML2XqJVzFSszaAPSrADVzEA8pIJJ7qMAOI+Kq2WrV6VKmru7tq1hrH7IUJcwmnpAi+BnCOJ+cKoaUqpJI7NuR8e07dcWxsK5YbCc9akLhTsDGrMvm6oZEamVQ+1VSTcbqQd+X+Lj8p4x05X62n/3pPQSYBBYmAxHKOXbni94dzBpkio50sAAWDGOkmLfHpjm/ivL16GYrXmk9XWt+cFdvcfw5YGpVsGAcGNur8JsAbQjmGd8sqyB5xn0kn1hvSYB2nSItiln81mFjLOR6edio72E2xB4azZd6aPINOSAZuZOmeYAF7dBOHLJ8J8xWckCdveJnr+5wb2GnyzZ0/TV3L4jnA42mcESpUpaXq06gUDy9BukcmG8Hf5YMnNBgadcaXAgE8ul/wA8JGXqNSryg0shIJ7ryjoeY2x0uj5WborUqAgaZJESpG4nn7j0wgWAcnmV13Smkh65xrMLUq13qPUCBPZAiTciAOkC5/M4Y/Dvh161NWFd1R2J8sMxBEm40kb3MbXnngs38O6dVjXWofLYzDGxnqBEz8r4OcN4AjkU3qsQBdEBRSASO5IkbEx2xostGkBe85o8QsTjjmFeDqhQZajT9AGlmQjSLdrA87EnHniHi1PJozE3VTfbue2Lmc4rTylMqIVR2A+AgCccC8e+JXzVTy1YkFpImf3/AGGBrQOwA57n0kJKqS3H3lLNeJBmMzUrV9ehlZVK7oDz237xjduI0BRGVyweC+qpUc7/AAgX5e7AgZXTCyZjph78N+EKfk0cw7a6lTU60yBpporFVZr3ZiCQCOXXHRsZak1HgTEXMTEy4eqKaksSQABzY2AHUziseHMarUhYqSGJ5ESCDHOREY6+eOUKdQqSqGibM0AEqAZU8iDbrIONeL5PIBmrPoNSoQ7VFqEAs66tpCzeT8cIXrcjJUiCPbEDwrwal9LpDNO60iCQyMV9Y9kFvsg3uOwnBbjHhDI1KdXM5TMLTRFJWkQWEqst62bVBtBAPx2HtfICnRK5E31FoLTIIAZQRyK2I56jhH4oNJOpHV2knVsLmyiPvnni0fxWyrY9n+IzUoHEO8KyGSbhtWu0vmqbwU1lYR4VGAgg6TfnznlC1WzbMugwb7/3xWRCbDBfg/CzUqIkqGYwochQCbgkk2GNkXmV6eRtuPkcZjpbfwlzFpztFTAJARiASATB5354zA7STn65y4MgEbGIiI2g8sMNJ87xGt9KNMV2oqupwEELTBPqJYEki0ncmOwXtK8gP+s/pi7k8o9QOlIgkqCyDzYYAggFRdoN9oETyxZ43kjb4r8SNxVqGXytKo7AsxBW+xAAvYcySQBAwvVOE5hEao1JgiVPLYx7L3OkgX6Qdj1xJk87ncktTytNJqsKWNNgQBPskjvPPFrwdmq7DM0RmkitScOlUMwqNDGf6WUAtq5adjaF1jGw4hsdW/eCFpMxAZSx2UHUY2soO3WBgpwvNvQrJVFIO9M6lVtcahq0zHQwY7Yo8HztfL1BVy9cU3gjWATpDRMh0I+QxUzdSrVd61WpqqM2p2OqWJ9yx+GHQIUzucrVHarWlqjnU7FTcx0JsOg6DGmXrxUUtAAYE+kWE3PtYHBXgfWRexl/hyxJl69QNqFa6n+rl1tB5b2tiHjEqN/iviKzR03YQ0Ajba8nnMdfa74qcZrMVp1EQgsDKzsRAjYzf8MCqmZeoxZ6hkxIX0i20AC1vvx7uioXYxJEsJ9W/c/2xmr6YJg9x/Mkgo5nM0qwr0VZXXf2iGAOx9MfpOOmeHPEX05VIcpUU/W0zEnlB5X5H89uesqx7YsIi/L4X3xQcGnUFehVC1F56jfqCIuO2L6npluXeaKLzWZ3bL5vyl1l1CAmVIMj7sEslxUyalQxTYDy+Vo/E45JwPxrTzJWnmWFKpsZnS3z/PrjoeXNGqqlzrFOSoBNyRzA3+eOP4d1Le75Tok12DPr84G8QZGsM5Ur5PSxZZaWAgwJixDWA7jC9w/htZAamoNVZ9RIuBAIKnnsTPO/uw70eB0nBemTTdiSCvIbAaduZ79b4s5ngygBTTDsFjWWCk955nB/uHYb8QgtSnHMWchxGlV9IZlqD2qb7jrEe0PdfEmfz9OsaGX8tahNmZW9VNR1K7W5Ej3YJf8AYtEjV5NR6gBIi8dPXt8zyx5w3gNSDppnUdy5AInkLke+N8Bq04KbwnbWNLHYdzzFnjngunTYV6JJCmWBvYyd99zPzxSy+Zr0naBrU7KDEH48uZ9+OjDJ1Cjq5CCn6mKjVPp9QE8xhUyPh2lWJqIKwRSZ1nSXtI8sBio6XxbOG/qE19LciIUY7eo/MQblMm6gu5Gp2LNpnc9JvYW74aKuYNKjSoQyqx+s5AX1G4m8HbY7Ys8P8N0qaU67GoNmAYm0dQZAPw+WLniPMUamXaWVTErMCD/f47nA2HUpCjB/iBd1KMVUbgHn2yKjkaT00pBgAGDtpMiP5bwZjHmd49TpWAUIoMWEg8gOv44Ss34kpZemUVyUtc2jr9/LCBx7xO1QkKxvsx/K20fH3YPp+md9+JhutRe+YZ8d+MmqE00JnlB23E+8/vfC1wnhpA8xtz3H4zirlMlJDMyn36+v+nBV6Y0kDR/1Hl/o9/zx2aq1QYE5juXOTJeA8N86q0iVBuJ3ttYn49vhhm8QcVo5XLNQotNdxB8s+x3YjYgbdTGFDKrURSq1Yky0axPyE40qZJjMNcncB/ntfCXoNlgZjsOB/eLxvmUK7uw0zUYTMEk3N2J95v1xQNA/yt8jg2vA6jmA5M9nv8xgrlvBQQa81XFNffHznDWsROTJAvh1QKh9dSmYlSIG28gyD7jbfDXxGstSkEqqrzHqWbxvI3X5/HpTThmQDSKj2PtQ9rb9I+7GNw+MuM0lQH6wr5Js4X7LETN94AMD44xOPFfUoO3qMfIwTq7SjmPCz6TUpDShI0Fmgz2nl3P5YveGOEVqYbM16UqZRASPURJeB0kXO2454p5/j+ZqKFYVGCiFBmAO2KacQZCCVq6hvYR35z8cP/5mUqR/eUCx7TG8XZ4xpqhQAABFO0AD7UnlzxmLf0XIP6yWUtciYg87csZhviL6Q8y1lPCdQkBq1ACeT6ifhGLeTy4yD+fVr0yUn0LctYgCCLcj8MLXEuKvVzC10RaJTSKYpCAgSNMd+cnGnGuK1s1WNfMNrqtAJgLAGwAA/viijNsW290vBh7xRmnzC5eu2Y8x6iuXo6lHkENpAgG4IuGN7HA/ifEa9dlasUJVAi6dCgKsgCFjrEnAnLUGdgiqWZiFVRckmwAA3OPc5k2pu1Ooul0JVlJEggkEe8EYaqhRgSS2oP8AT8xj1qTTsh9zr/c4ipZYASZB+HY9On4/Nx8D+IMjlaFVcyi+a8jUULFkIEDYhYO4tO9+VWOVXUAT7oSrqOMxdplo9npsca0qNSY0tM8xPOTtiiwEkooCkkrtOn7I26Y0SqV5fCF+O8YMHMEiG6quASFe3Sf8YrUqlTUPTUEzYA+43/e2KT16kGCw9w//AK3GIVq1T9prDp/fpi8yQoWqkkhanuggx8saJRrblW+JHTvihoqXJJkdB+uPGyjfy36kKPyxJJbzvCWcTABjfUv33xJwXimbyrWcaBuCykfC8/LEWW4cSJ3N4HpG3wxlSmzWA0i8+oX/AHP44EqDzCBIORH7hf8AFJAQG9J2M7fMcuc4b+HePaFWDqVj7/39+OFrwkN0+ZP5YjPBKoGtdgYnvhDdMpjhee8+j6PieiAbgT364jXxMgsL8xcb/D/OPm80syPtP/zH9ceipmv56v8AzN+uAPSiELx6T6Fy/GKaF6jH2iRBJvYcm5fDC3xvxmquG8wDTsAQAI2xx2pTzDD1M597McRpwyoeQGAPRIRgwv3TA5AnQeJfxNa4Ulp6frbCjxHxbXq7W+JJ++33YrUuDdTi5S4ao5D4xjQnTIvaJe927wd9KdxDyTHMjnub4zL0Qt5v2j9MEKoG1vl37YqlT1w3GIqTrmWAjWfnjYZ+oAB5jQLj1G354qtPX92xE1S0TfEzJLeY4nVO9Rz/ALn/AFxJw5q1eqKau5Y/1NYfPApx3+7Frh+dak2pCJIjbfY9ZwLZxtzJOiLw+rSQ0soheqY11D/+MHYmTf3d+m61ksrmK2ZcVyz1UWdOoqSAY9JXYbXjng7wHxnladP636S1SxgBCCecEED/AHN6r7nHuS8XVMzmqNOnlVUBmKszepVPtklFFiNwZExfY4whLADkb+veDFXxB5tGr5XnVCNIJBY2mbb/AI7zgA9Zjcj42/zgnx5YzFQMrq+o69Thrm8ghVtBBFsCn9xxuT+kZlzVqrdcR6jO+Nie3340YYOSbec38zfM4zGkY9xJUtirjCef7/HHmMwMKS06saWQnULyJBVtRiDM7AGbQT2nBDPO9Sq1fMNqdjJNvURuTAxmMxckhYhzeI92PDTAiY+/tjMZi5UtUhYGF+XvxUdhI7jb9jGYzFyS35IC6rjqZHe23b8MYtNAe/c7fJcZjMXJJfKBm3M89uZ5Y1SgCesGN+fyGMxmJJPdbC0WO9/7401Ebjcfj8cZjMSST0d+cYKUM16CCAwIKqTM09JDHTtHtbXBk88ZjMSXKdatiu++9iJHukj8QcZjMQyCerTFv7d+ox4WXqef5YzGYqSetmU2v+wMaZmqomAYA5n/ADj3GYuVKtIhjtf++NKogxb3X64zGYEyxMcfP/GKtQRvAxmMxRkkDcsRmr+yMZjMSSX6EBC7fd91v3v8ivBuOrSRgAVeCxaB6o2W23LtMnGYzAWKGG8qC+L8UNd9ZmygTABMczG9z+9gPZpxmMwSqANpJoWxJlqBaT2nGYzBCSb+SMZjMZi5J//Z",
                            ItemName = "Pizza",
                            Unitprice = 200m
                        });
                });

            modelBuilder.Entity("Fooddeliveryapp1.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("Fooddeliveryapp1.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Fooddeliveryapp1.Models.Cart", b =>
                {
                    b.HasOne("Fooddeliveryapp1.Models.Item", "Items")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fooddeliveryapp1.Models.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Items");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Fooddeliveryapp1.Models.User", b =>
                {
                    b.HasOne("Fooddeliveryapp1.Models.Role", "Roles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}