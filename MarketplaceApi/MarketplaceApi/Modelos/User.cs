﻿namespace MarketplaceApi.Modelos
{
   
        public class User
        {
            public int UserId { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Senha { get; set; }
            public string Tipo { get; set; }  // "Consumidor" ou "Produtor"
        }
    
}
