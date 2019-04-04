import React from 'react'
import "./CartItemsList.css"
import CartItems  from '../CartItems';


const CartList = (props) => {
    
  return (
    <div className="cart-list-container">
    {/*productData is the key in the container */}
    {/** item={item} will return all objects in the array */}
      {props.cartData.map((item, i) => <CartItems key={i} item={item} />) }
    </div>
  )
}


export default CartList