import React from 'react'
import "./ProductList.css"
import ProductItem  from '../ProductItem';


const ProductsList = (props) => {
   
  return (
    <div className="ProductList">
    {/*productData is the key in the container */}
    {/** item={item} will return all objects in the array */}
      {props.productData.map((item, i) => <ProductItem key={i} item={item} />) }
    </div>
  )
}


export default ProductsList