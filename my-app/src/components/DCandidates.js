import reac , {useState,useEffect} from "react"
import {connect} from "react-redux"
import { DCandidate } from "../reduces/dCandidate"
import * as actions from "../actions/dCandidate"

const DCandidates = (props) => {
    return (<div> Form Candidates </div>)

    useEffect(()=>{
        props.fetchAllCandidates()
    },[]);
}

const mapStateToProps = state =>({
        dCandidateList: state.dCandidate.list
    
})

const mapActionsToProp = {
    fetchAllCandidates: actions.fetchall
}

export default connect(mapStateToProps,mapActionsToProp)(DCandidates)