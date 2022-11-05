import React, {useState,useEffect} from 'react'
import Nav from '../../components/Nav';
import Api from '../../api/endpoints'

const MyAdventure = () => {
    const [adventure, setAdventure]= useState("");
    const [userAdventure, setuserAdventure]= useState({});
    const [notReady, setnotReady]= useState(false);
    const [error, setError]= useState("User adventure is not ready, kindly create it");
    useEffect(() => {
      const userAdventureId=window.localStorage.getItem('userAdventureId');
      if(userAdventureId)
      {
        const fetchUserAdventure = async () => {
          var userAdventureReponse=await Api.getUserAdventure(userAdventureId);
          if(userAdventureReponse.error)
          {
            setError(userAdventureReponse.error);
          }
          else
          {
            setAdventure(userAdventureReponse.adventure);
            setuserAdventure(userAdventureReponse.userAdventure)
          }
        }
        fetchUserAdventure();        
      }
      else{
        setnotReady(true);
      }
    }, []);

    const showQuestions = (question) =>
    {
      return (<div key={question.id} id={question.id}><p className="selectedquestion" name={question.title} >{question.title}</p>
        <div>{showChoices(question.choices)}</div>
      </div>);
    }
    const isThisSelectedChoice = (choice) =>
    {
        if(userAdventure.userChoices.find(c=> c.choiceId===choice.id))
        {
          return true;
        }
        return false;
    }
    
    const showChoices = (choices) =>
    {
      let myNextQuestion = null;
      choices.map((choice)=>{
        if(userAdventure.userChoices.find(c=> c.choiceId===choice.id))
        {
          myNextQuestion =choice.nextQuestion;
        }
      });
      
      return (
        <div>
          {
            choices.map((choice)=>(
              <>
              {isThisSelectedChoice(choice)?<button className='selectectedChoice' id={choice.id} >{choice.title}</button>:<button id={choice.id} >{choice.title}</button>}
              </>
            ))
          }
          {
              (myNextQuestion !=null)?showQuestions(myNextQuestion):null
          }
        </div>
      );
    }
  return (
    <>
    <Nav />
    <div><p style={{textDecoration:'underline'}}>Green buttons are your highlighted choices</p></div>
    {notReady && error && <div>{error}</div>}
    {adventure && adventure.questions[0] &&  showQuestions(adventure.questions[0])}
    </>
    
  )
}

export default MyAdventure