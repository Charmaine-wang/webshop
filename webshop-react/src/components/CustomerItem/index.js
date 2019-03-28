import React, { Component } from 'react'
import "./ProductItem.css"
import axios from 'axios'
// import Button from "../Button"

class ProductItem extends Component {

  constructor(props) {
    super(props)
            this.state = {
          cartGuid: ""
        }
      }
          
      componentDidMount() {
            this.fetchAdvice();
          }
    
      fetchAdvice = () => {

          //here you fetch the api (table product.db)
  axios.get(`http://localhost:5000/api/cartid`)
    .then(response => {
      this.setState({
        cartGuid: response.data
      })
    })
  }

  handleSubmit(e){
      e.preventDefault();
        
      const qty = e.target[0].value;
      const id = e.target[1].value;
      
      let myGuid =  localStorage.getItem("my-guid")

      if(myGuid == null){
        let guid = e.target[2].value;
        localStorage.setItem("my-guid", guid)
      }
     let guid = localStorage.getItem("my-guid")
      const send = {cart_guid: guid, product_id: id, product_qty: qty }
      console.log(send);
              fetch('http://localhost:5000/api/customer', {
                headers: {
                  'Accept': 'application/json',
                  'Content-Type': 'application/json'
                },
                method: 'POST',
                body: JSON.stringify(send)
              })
      
  }

 

  render() {
    // console.log(document.forms[0])
    return(
      <div className="RecipeItem">
      
        {/*item is the key you find in ProductList, product_name */ }
        <h1>{ this.props.item.product_name }</h1>
        <img className="product-img" src={this.props.item.product_img} alt="" />
        
         <form onSubmit={this.handleSubmit} action="index.html">
          <input type="hidden" name="qty" value="1" />
          <input type="hidden" name="cart_guid" value={this.state.cartGuid} />
          <button type="submit" className="cta-buyBtn">Add to cart</button>
         </form>
        {/* <Button /> */}
      </div>
    )
  }
  }
export default ProductItem