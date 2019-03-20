import React, { Component } from 'react';

import axios from 'axios'

class App extends Component {
      constructor() {
        super()
        this.state = {
          products: []
        }
      }


          componentDidMount() {
            this.fetchAdvice();
          }
      

      fetchAdvice = () => {
        
        axios.get(`/api/product`)
          .then(response => {
          this.setState({
            products: response.data
          })
        })
      }

  render(props) {
    //here you can console.log to see data
 
   
    return (
      <div className="App">
      {this.state.products.map((item, key) => <p key={key}>{item.product_name}</p>) }
   </div>
    );
  }
}

export default App;