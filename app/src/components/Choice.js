import React from 'react'

const Choice = ({choice, setMainQuestion}) => {
    const {id,title,nextQuestion} = choice;
  return (
    <button id={id} onClick={()=>setMainQuestion(nextQuestion)}>{title}</button>
  )
}

export default Choice