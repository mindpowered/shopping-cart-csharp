/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

using System.Collections.Generic;

/**
 * An Shopping Cart Library
 * Add items and show a summary at checkout
 */
namespace mindpowered.shoppingcart {
	public delegate void MyCallbackDelegate(object o);

	public class ShoppingCart
	{
		public ShoppingCart()
		{
			global::maglev.MagLev bus = global::maglev.MagLev.getInstance("default");
			global::shoppingcart.ShoppingCart myinstance = new global::shoppingcart.ShoppingCart(bus);
		}

		/**
		 * Create a new shopping cart
		 * @param storeId 
		 * @return {string} cartId
		*/
		public string Create(string storeId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(storeId);
			string ret = "";
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ShoppingCart.Create", args, async_callback);
			return ret;
		}

		/**
		 * Add an item to a cart
		 * @param cartId 
		 * @param itemId 
		 * @param qty quantity
		 * @param price price
		 * @return {double} cart item index
		*/
		public double AddItem(string cartId, string itemId, double qty, double price)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(cartId);
			args.push(itemId);
			args.push(qty);
			args.push(price);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ShoppingCart.AddItem", args, async_callback);
			return ret;
		}

		/**
		 * Get a list of items in a cart
		 * @param cartId 
		 * @return {object[]} array of item objects
		*/
		public object[] ListItems(string cartId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(cartId);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ShoppingCart.ListItems", args, async_callback);
			return ret;
		}

		/**
		 * Remove an item from a cart
		 * @param cartId 
		 * @param idx item index
		*/
		public void RemoveItem(string cartId, double idx)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(cartId);
			args.push(idx);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ShoppingCart.RemoveItem", args, async_callback);
		}

		/**
		 * Update cart item quantity
		 * @param cartId 
		 * @param idx item index
		 * @param qty quantity
		*/
		public void UpdateQty(string cartId, double idx, double qty)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(cartId);
			args.push(idx);
			args.push(qty);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ShoppingCart.UpdateQty", args, async_callback);
		}

		/**
		 * Count the items in a cart
		 * @param cartId 
		 * @return {double} number of items
		*/
		public double CountItems(string cartId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(cartId);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ShoppingCart.CountItems", args, async_callback);
			return ret;
		}

		/**
		 * Get a summary for a shopping cart
		 * @param cartId 
		 * @return {object} summary
		*/
		public object GetCartSummary(string cartId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(cartId);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ShoppingCart.GetCartSummary", args, async_callback);
			return ret;
		}

		/**
		 * Clear all items from a shopping cart
		 * @param cartId 
		*/
		public void Clear(string cartId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(cartId);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ShoppingCart.Clear", args, async_callback);
		}

	}
}

