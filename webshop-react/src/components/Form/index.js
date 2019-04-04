import React from 'react'

const Form = (props) => {
    return (

        <div>
            <form>
                <div>
                    <label for="username">Name</label>
                    <input type="username" name="username" placeholder="Username" />
                </div>
                
                <div>
                <label for="name">Adress</label>
                <input type="name" name="name" placeholder="Name" />
                </div>

                <button class="create-button" type="submit" name ="submit" class="btn btn-primary">CREATE ACCOUNT</button>
            </form>
        </div>
    )
  }
export default Form

