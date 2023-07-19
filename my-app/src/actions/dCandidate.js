import axios from "axios"
import api from "./api"


export const ACTION_TYPES = {
    CREATE : 'CREATE',
    UPDATE : 'UPDATE',
    DELETE : 'DELETE',
    FETCH_ALL : 'FETCH_ALL'
}

export const fetchall = () => dispatch =>{

    api.DCandidate().fetchall
      .then(responce =>{
        console.log(responce)
        dispatch({
            type:ACTION_TYPES.FETCH_ALL,
            paytood: responce.data
        })
      })
      .catch(err=> console.log(err));
}