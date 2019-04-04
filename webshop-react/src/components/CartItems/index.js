import React, { Component } from 'react'
import "./CartItems.css"
import axios from 'axios'


class CartItems extends Component {
  constructor() {
      super()
      this.state={
      product: {}
  /* fetch(product/props.item.product_id) */
  /*        then ( state.productData = response) */
  }
}
      componentDidMount() {
        this.fetchAdvice();
      }
    
      fetchAdvice = () => {
        //here you fetch the api (table product.db)
        axios.get(`http://localhost:5000/api/product/${this.props.item.product_id}`)
          .then(response => {
          this.setState({
            product: response.data[0]
          })
        })
      }

 
  render() {
  console.log(this.state.product)
  return(


    <div className="CartItem">
    
      {/*item is the key you find in ProductList, product_name */ }
      <h1>{this.state.product.product_name}</h1>
      <h1>{this.state.product.cart_guid}</h1>
      <img className="product-img" src={this.state.product.product_img} alt="" />
      
    </div>
  )
  }

  

}
export default CartItems;