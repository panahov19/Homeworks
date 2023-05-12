using System;
using System.Collections.Generic;





namespace ZooShopAdmin.Model

{

    public class CategoriesModel
    {
        public class Category
        {
            public string? Name { get; set; }

            public List<Product> Products_list { get; set; }
            public List<string> Products_list_names { get; set; }

        }

        public class Categories
        {
            public static Category First =  new Category()   { Name = "Cat"  ,   Products_list = Products.Products_list_First ,  Products_list_names = Products.Products_list_First_names };
            public static Category Second = new Category()   { Name = "Dog",     Products_list = Products.Products_list_Second,  Products_list_names = Products.Products_list_Second_names};
            public static Category Third =  new Category()   { Name = "Turtle",  Products_list = Products.Products_list_Third,   Products_list_names = Products.Products_list_Third_names };
            public static Category Fourth = new Category()   { Name = "Hamster", Products_list = Products.Products_list_Fourth,  Products_list_names = Products.Products_list_Fourth_names };
            public static Category Fifth =  new Category()   { Name = "Parrot",  Products_list = Products.Products_list_Fifth,   Products_list_names = Products.Products_list_Fifth_names };
            public static Category Sixth =  new Category()   { Name = "Rabbit",  Products_list = Products.Products_list_Sixth,   Products_list_names = Products.Products_list_Sixth_names };

            public static List<Category> Categories_list = new();
            public static List<string> Categories_list_names = new();

            public static  void Add_Default_Categories()
            {
                Categories_list_names.Add(First.Name);
                Categories_list_names.Add(Second.Name);
                Categories_list_names.Add(Third.Name);
                Categories_list_names.Add(Fourth.Name);
                Categories_list_names.Add(Fifth.Name);
                Categories_list_names.Add(Sixth.Name);
                Categories_list.Add(First);
                Categories_list.Add(Second);
                Categories_list.Add(Third);
                Categories_list.Add(Fourth);
                Categories_list.Add(Fifth);
                Categories_list.Add(Sixth);
            }

        }

        public class Product
        {
            public Category? category;

            public string? Brand { get; set; }
            public Int32? Price { get; set; }

           

        }

        public class Products : Category
        {
            
            public static List<Product> Products_list_First = new List<Product>();
            public static List<Product> Products_list_Second = new List<Product>();
            public static List<Product> Products_list_Third = new List<Product>();
            public static List<Product> Products_list_Fourth = new List<Product>();
            public static List<Product> Products_list_Fifth = new List<Product>();
            public static List<Product> Products_list_Sixth = new List<Product>();

            public static List<string> Products_list_First_names = new List<string>();
            public static List<string> Products_list_Second_names = new List<string>();
            public static List<string> Products_list_Third_names = new List<string>();
            public static List<string> Products_list_Fourth_names = new List<string>();
            public static List<string> Products_list_Fifth_names = new List<string>();
            public static List<string> Products_list_Sixth_names = new List<string>();






            public static Product product1 = new Product() { Brand = "Proplan Diet",        Price = 8,   category = Categories.First};
            public static Product product2 = new Product() { Brand = "Proplan Sterilised" , Price = 10 , category = Categories.First};
            public static Product product3 = new Product() { Brand = "Proplan Kitten",      Price = 7  , category = Categories.First};
            public static Product product4 = new Product() { Brand = "Kitekat Chicken",     Price = 7,   category = Categories.First};
            public static Product product5 = new Product() { Brand = "Kitekat Fish",        Price = 8,   category = Categories.First};
            public static Product product6 = new Product() { Brand = "Royal Canin Adult",   Price = 14,  category = Categories.First};
            public static Product product7 = new Product() { Brand = "Royal Canin Digest",  Price = 14,  category = Categories.First};

              
            public static Product product8 =  new Product() { Brand = "PediGree Beef",      Price = 12, category = Categories.Second };
            public static Product product9 =  new Product() { Brand = "PediGree Bird",     Price = 11, category = Categories.Second };
            public static Product product10 = new Product() { Brand = "Choppi Mix",         Price = 10, category = Categories.Second };
            public static Product product11 = new Product() { Brand = "Proplan Sensitive",  Price = 13, category = Categories.Second };
            public static Product product12 = new Product() { Brand = "Proplan Robust",     Price = 9, category =  Categories.Second };
            public static Product product13 = new Product() { Brand = "Brit Gestro",        Price = 10, category = Categories.Second };
            public static Product product14 = new Product() { Brand = "Brit Labrador",      Price = 11, category = Categories.Second };


            public static Product product15 = new Product() { Brand = "OXBOW Essentials",  Price = 6, category = Categories.Third    };
            public static Product product16 = new Product() { Brand = "VitaPrime Sunseed", Price = 7, category = Categories.Third    };
            public static Product product17 = new Product() { Brand = "SunBurst Diet",     Price = 9, category = Categories.Third    };
            public static Product product18 = new Product() { Brand = "eCotrition Yogies", Price = 5, category = Categories.Third    };
            public static Product product19 = new Product() { Brand = "VitaKraft Menu",    Price = 7, category = Categories.Third    };


            public static Product product20 = new Product() { Brand = "Koytee timothy",    Price = 11, category = Categories.Fourth, };
            public static Product product21 = new Product() { Brand = "Purina Complete",   Price = 8,  category = Categories.Fourth, };
            public static Product product22 = new Product() { Brand = "OXBOW Young",       Price = 9,  category = Categories.Fourth, };
            public static Product product23 = new Product() { Brand = "Tropical Carnival", Price = 12, category = Categories.Fourth, };
            public static Product product24 = new Product() { Brand = "SunBurst Fruit",    Price = 7,  category = Categories.Fourth, };


            public static Product product25 = new Product() { Brand = "Reptomin Sticks",   Price = 5,  category = Categories.Fifth,  };
            public static Product product26 = new Product() { Brand = "Ultra Fresh Sticks",Price = 8,  category = Categories.Fifth,  };
            public static Product product27 = new Product() { Brand = "Flukers Buffet",    Price = 11, category = Categories.Fifth,  };
            public static Product product28 = new Product() { Brand = "ZooMed Gourmet",    Price = 6,  category = Categories.Fifth,  };
            public static Product product29 = new Product() { Brand = "Mazuri Aquatic",    Price = 9,  category = Categories.Fifth,  };


            public static Product product30 = new Product() { Brand = "Vita Sticks",       Price = 7,  category = Categories.Sixth,  };
            public static Product product31 = new Product() { Brand = "Koythee Sticks",    Price = 9,  category = Categories.Sixth,  };
            public static Product product32 = new Product() { Brand = "Prime Buffet",      Price = 5,  category = Categories.Sixth,  };
            public static Product product33 = new Product() { Brand = "ZooMed Complete",   Price = 10, category = Categories.Sixth,  };
            public static Product product34 = new Product() { Brand = "Purina Aquatic",    Price = 8,  category = Categories.Sixth,  };


            public static void Add_Default_Products()
            {
                Products_list_First.Add(product1);
                Products_list_First.Add(product2);
                Products_list_First.Add(product3);
                Products_list_First.Add(product4);
                Products_list_First.Add(product5);
                Products_list_First.Add(product6);
                Products_list_First.Add(product7);

                Products_list_First_names.Add(product1.Brand + " " + product1.Price.ToString() + " $") ;
                Products_list_First_names.Add(product2.Brand + " " + product2.Price.ToString() + " $");
                Products_list_First_names.Add(product3.Brand + " " + product3.Price.ToString() + " $");
                Products_list_First_names.Add(product4.Brand + " " + product4.Price.ToString() + " $");
                Products_list_First_names.Add(product5.Brand + " " + product5.Price.ToString() + " $");
                Products_list_First_names.Add(product6.Brand + " " + product6.Price.ToString() + " $");
                Products_list_First_names.Add(product7.Brand + " " + product7.Price.ToString() + " $");




                Products_list_Second.Add(product8);
                Products_list_Second.Add(product9);
                Products_list_Second.Add(product10);
                Products_list_Second.Add(product11);
                Products_list_Second.Add(product12);
                Products_list_Second.Add(product13);
                Products_list_Second.Add(product14);


                Products_list_Second_names.Add(product8.Brand + " " + product8.Price.ToString() + " $");
                Products_list_Second_names.Add(product9.Brand + " " + product9.Price.ToString() + " $");
                Products_list_Second_names.Add(product10.Brand + " " + product10.Price.ToString() + " $");
                Products_list_Second_names.Add(product11.Brand + " " + product11.Price.ToString() + " $");
                Products_list_Second_names.Add(product12.Brand + " " + product12.Price.ToString() + " $");
                Products_list_Second_names.Add(product13.Brand + " " + product13.Price.ToString() + " $");
                Products_list_Second_names.Add(product14.Brand + " " + product14.Price.ToString() + " $");

                Products_list_Third.Add(product15);
                Products_list_Third.Add(product16);
                Products_list_Third.Add(product17);
                Products_list_Third.Add(product18);
                Products_list_Third.Add(product19);

                Products_list_Third_names.Add(product15.Brand + " " + product15.Price.ToString() + " $");
                Products_list_Third_names.Add(product16.Brand + " " + product16.Price.ToString() + " $");
                Products_list_Third_names.Add(product17.Brand + " " + product17.Price.ToString() + " $");
                Products_list_Third_names.Add(product18.Brand + " " + product18.Price.ToString() + " $");
                Products_list_Third_names.Add(product19.Brand + " " + product18.Price.ToString() + " $");



                Products_list_Fourth.Add(product20);
                Products_list_Fourth.Add(product21);
                Products_list_Fourth.Add(product22);
                Products_list_Fourth.Add(product23);
                Products_list_Fourth.Add(product24);

                Products_list_Fourth_names.Add(product20.Brand + " " + product20.Price.ToString() + " $");
                Products_list_Fourth_names.Add(product21.Brand + " " + product21.Price.ToString() + " $");
                Products_list_Fourth_names.Add(product22.Brand + " " + product22.Price.ToString() + " $");
                Products_list_Fourth_names.Add(product23.Brand + " " + product23.Price.ToString() + " $");
                Products_list_Fourth_names.Add(product24.Brand + " " + product24.Price.ToString() + " $");

                Products_list_Fifth.Add(product25);
                Products_list_Fifth.Add(product26);
                Products_list_Fifth.Add(product27);
                Products_list_Fifth.Add(product28);
                Products_list_Fifth.Add(product29);

                Products_list_Fifth_names.Add(product25.Brand + " " + product25.Price.ToString() + " $");
                Products_list_Fifth_names.Add(product26.Brand + " " + product26.Price.ToString() + " $");
                Products_list_Fifth_names.Add(product27.Brand + " " + product27.Price.ToString() + " $");
                Products_list_Fifth_names.Add(product28.Brand + " " + product28.Price.ToString() + " $");
                Products_list_Fifth_names.Add(product29.Brand + " " + product29.Price.ToString() + " $");

                Products_list_Sixth.Add(product30);
                Products_list_Sixth.Add(product31);
                Products_list_Sixth.Add(product32);
                Products_list_Sixth.Add(product33);
                Products_list_Sixth.Add(product34);


                Products_list_Sixth_names.Add(product30.Brand + " " + product30.Price.ToString() + " $");
                Products_list_Sixth_names.Add(product31.Brand + " " + product31.Price.ToString() + " $");
                Products_list_Sixth_names.Add(product32.Brand + " " + product32.Price.ToString() + " $");
                Products_list_Sixth_names.Add(product33.Brand + " " + product33.Price.ToString() + " $");
                Products_list_Sixth_names.Add(product34.Brand + " " + product34.Price.ToString() + " $");
            }




        }

    }
}

   



   







