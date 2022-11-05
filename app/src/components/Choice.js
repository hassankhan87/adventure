import React from 'react'

const Choice = ({choice, setMainQuestion,setUserChoices}) => {
    const {id,title,nextQuestion} = choice;
    const handleChoice = () =>
    {
      setMainQuestion(nextQuestion);
      setUserChoices(userchoices => [...userchoices, {choiceId:id}]);
    }
  return (
    <button id={id} name={title} onClick={()=>handleChoice()}>{title}</button>
  )
}

export default Choice