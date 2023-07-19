import axios from "axios"

const baseUrl = "https://localhost:7038/api/";

// eslint-disable-next-line import/no-anonymous-default-export
export default{

    DCandidate (url = baseUrl + 'ReceiveAllProduct"'){
        return{
            fetchall: ()=> axios.get(url),
            fetchById: id => axios.get(url + id),
            create: newRecord => axios.post(url,newRecord),
            update:(id,updateRecord)=> axios.post(url + id,updateRecord),
            delete: id => axios.delete(url + id)
        }
    }
}