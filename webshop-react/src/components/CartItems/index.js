import React from 'react'
import "./CartItems.css"


const CartItems = (props) => {
  return(
    <div className="CartItem">
    
      {/*item is the key you find in ProductList, product_name */ }
      <h1>{ props.item.product_name } {props.item.product_name}</h1>
      
    </div>
  )
  }
export default CartItems;