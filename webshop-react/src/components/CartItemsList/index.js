import React from 'react'
import "./CartItemsList.css"
import CartItems  from '../CartItems';


const ProductsList = (props) => {
    
  return (
    <div className="ProductList">
    {/*productData is the key in the container */}
    {/** item={item} will return all objects in the array */}
      {props.productData.map((item, i) => <CartItems key={i} item={item} />) }
    </div>
  )
}


export default ProductsList