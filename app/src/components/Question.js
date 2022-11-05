import React, {useState} from 'react'
import Choice from './Choice'
import Api from '../api/endpoints'
import { useNavigate } from 'react-router-dom';

const Question = ({question,userAdventure}) => {
    const [mainQuestion, setMainQuestion] = useState(question);
    const [userChoices, setUserChoices] = useState([]);
    const [error, setError]= useState("");
    const [loading,setLoading] = useState(false);
    const navigate = useNavigate();

    const handleUserChoices = async () =>
    {
      setLoading(true);
        
        const data = Object.assign(userAdventure, {userChoices:userChoices});
        var userAdventureReponse=await Api.createUserAdventure(data);
        if(userAdventureReponse.error)
        {
          setError("We cannot show your moves at the movement");
          setLoading(false);
        }
        else{
          setLoading(false);
          window.localStorage.setItem('userAdventureId',userAdventureReponse.id);
          navigate('/my/adventure/:'+userAdventureReponse.id);          
        }

    }
    const setQuestionLayout = ()=>
    {
      if(mainQuestion && mainQuestion.choices && mainQuestion.choices.length >0)
      {
        return (<div id={mainQuestion.id} className="question">{mainQuestion.title}</div>);
      }else{
        return (<div><div id={mainQuestion.id} className="question">{mainQuestion.title}</div>
        <div>{error}</div>
        <div><button id='gotomyadventure' onClick={handleUserChoices}>My Adventure</button></div></div>)
      }
    }
    return (
    <>
    {setQuestionLayout()}
    
    {mainQuestion && mainQuestion.choices && mainQuestion.choices.map((choice,index)=>(
        <Choice key={index} choice={choice} setMainQuestion={setMainQuestion} setUserChoices={setUserChoices}/>
    ))}
    </>    
  )
}

export default Question