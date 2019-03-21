import React from 'react'
import "./CartItems.css"


const CartItems = (props) => {
  return(
    <div className="CartItem">
    
      {/*item is the key you find in ProductList, product_name */ }
      <h1>{ props.item.product_name }</h1>
      <img className="product-img" src={props.item.product_img} />
    </div>
  )
  }
export default CartItems;