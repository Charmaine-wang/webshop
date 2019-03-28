import React from 'react'
import "./CartItemsList.css"
import OrderItems  from '../CartItems';


const OrderItemsList = (props) => {
    console.log(props.productData)
  return (
    <div className="ProductList">
    {/*productData is the key in the container */}
    {/** item={item} will return all objects in the array */}
      {props.productData.map((item, i) => <OrderItems key={i} item={item} />) }
    </div>
  )
}
export default OrderItemsList