import React, { useState,useEffect } from 'react'
import Question from '../../components/Question';
import Api from '../../api/endpoints'
import Nav from '../../components/Nav';


const TakeAdventure = () => {
    const [adventure, setAdventure]= useState("");
    const [userAdventure, setuserAdventure]= useState({});
    const [notReady, setnotReady]= useState(false);
    const [error, setError]= useState("Adventure is not ready, kindly create it");
    useEffect(() => {
      const adventureId=window.localStorage.getItem('adventureId');
      if(adventureId)
      {
        const fetchAdventure = async () => {
          var adventureReponse=await Api.getAdventure(adventureId);
          if(adventureReponse.error)
          {
            setError(adventureReponse.error);
          }
          else
          {
            const userId=window.localStorage.getItem('userId');
            setAdventure(adventureReponse);
            setuserAdventure({adventureId:adventureId, userId:userId,session:new Date().toJSON()})
          }
        }
        fetchAdventure();        
      }
      else{
        setnotReady(true);
      }
    }, []);
  return (
    <>
    <Nav />
    {notReady && error && <div>{error}</div>}
    {adventure && adventure.questions[0] && <Question key={0} question={adventure.questions[0]} userAdventure={userAdventure} />}
    </>
  )
}

export default TakeAdventure