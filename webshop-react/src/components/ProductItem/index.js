import React from 'react'
import "./ProductItem.css"


const ProductItem = (props) => {
  return(
    <div className="RecipeItem">
    
      {/*item is the key you find in ProductList, product_name */ }
      <h1>{ props.item.product_name }</h1>
      <img className="product-img" src={props.item.product_img} alt="" />
      
    </div>
  )
  }
export default ProductItem
