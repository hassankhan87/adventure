import React, {useState} from 'react'
import Choice from './Choice'

const Question = ({question}) => {
    const [mainQuestion, setMainQuestion] = useState(question);
    
    return (
    <>
    {mainQuestion && <div id={mainQuestion.id} className="question">{mainQuestion.title}</div>}
    
    {mainQuestion && mainQuestion.choices && mainQuestion.choices.map((choice,index)=>(
        <Choice key={index} choice={choice} setMainQuestion={setMainQuestion}/>
    ))}
    </>    
  )
}

export default Question