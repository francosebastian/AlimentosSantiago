using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlimentosSantiago.Dto;
namespace AlimentosSantiago.Web.WebUtils
{

    /**
     * The ShoppingCart class
     * 
     * Holds the items that are in the cart and provides methods for their manipulation
     */
    public class CarritoCompras
    {
        #region Properties

        public List<DetallePedidoMenu> Items { get; private set; }

        #endregion

        #region Singleton Implementation



        // Propiedad readonly que solo puede ser inicializada en el constructor
        public static readonly CarritoCompras Instance;

        // Constructor statico que es llamado cuando la clase es cargada en la memoria
        static CarritoCompras()
        {
            // If the cart is not in the session, create one and put it there
            // Otherwise, get it from the session
            if (HttpContext.Current.Session["ASPNETShoppingCart"] == null)
            {
                Instance = new CarritoCompras();
                Instance.Items = new List<DetallePedidoMenu>();
                HttpContext.Current.Session["ASPNETShoppingCart"] = Instance;
            }
            else {
                Instance = (CarritoCompras)HttpContext.Current.Session["ASPNETShoppingCart"];
            }
        }

        // Constructor protected asegura qu el objeto no pueda ser creado afuera de la clase
        protected CarritoCompras() { }

        #endregion

        #region Item Modification Methods
        /**
         * AddItem() - Agrega items en el carro
         */
        public void AddItem(Plato plato)
        {
            // Create a new item to add to the cart
            DetallePedidoMenu newItem = new DetallePedidoMenu();
            newItem.PlatoId = plato.Id;
            if (plato.PromocionActiva)
            {
                newItem.PrecioUnitario = plato.PrecioPromocion;
            }
            else
            {
                newItem.PrecioUnitario = plato.Precio;
            }

            // If this item already exists in our list of items, increase the quantity
            // Otherwise, add the new item to the list
            if (Items.Contains(newItem))
            {
                foreach (DetallePedidoMenu item in Items)
                {
                    if (item.Equals(newItem))
                    {
                        item.Cantidad++;
                        return;
                    }
                }
            }
            else {
                newItem.Cantidad = 1;
                Items.Add(newItem);
            }
        }

        /**
         * SetItemQuantity() - Cambia la cantidad de un item en el carro
         */
        public void SetItemQuantity(Plato plato, int quantity)
        {
            // If we are setting the quantity to 0, remove the item entirely
            if (quantity == 0)
            {
                RemoveItem(plato);
                return;
            }

            // Find the item and update the quantity
            DetallePedidoMenu updatedItem = Items.FirstOrDefault(i => i.PlatoId == plato.Id);

            foreach (DetallePedidoMenu item in Items)
            {
                if (item.Equals(updatedItem))
                {
                    item.Cantidad = quantity;
                    return;
                }
            }
        }

        /**
         * RemoveItem() - Remueve un item del carrito de compras
         */
        public void RemoveItem(Plato plato)
        {
            DetallePedidoMenu removedItem = Items.FirstOrDefault(i => i.PlatoId == plato.Id);
            Items.Remove(removedItem);
        }
        #endregion

        #region Reporting Methods
        /**
         * GetSubTotal() -Retorna el total de la suma del carro antes 
         *                 de efectuar la compra.    
         */
        public decimal GetSubTotal()
        {
            decimal subTotal = 0;
            foreach (DetallePedidoMenu item in Items)
                    subTotal += item.PrecioUnitario;
            return subTotal;
        }
        #endregion
    }
}