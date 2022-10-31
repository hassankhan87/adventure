import React, { useState,useEffect } from 'react'
import Question from '../../components/Question';



const TakeAdventure = () => {
    const [adventure, setAdventure]= useState();
    useEffect(() => {
        fetch(`https://localhost:49159/Adventure`)
        .then((response) => response.json())
        .then((data) => setAdventure(data))
        .catch((err) => {
        console.log(err.message);
        });
    }, []);
  return (
    <>
    {adventure && adventure.questions.map((question,index)=> (
        <Question key={index} question={question} />
    ))}    
    </>
  )
}

export default TakeAdventure