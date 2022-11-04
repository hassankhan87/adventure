import React, { useState,useEffect } from 'react'
import Question from '../../components/Question';



const TakeAdventure = () => {
    const [adventure, setAdventure]= useState();
    useEffect(() => {
        fetch(`https://localhost:49153/api/adventure/08dabd19-c652-4925-870d-5a9ef5acce24`)
        .then((response) => response.json())
        .then((data) => setAdventure(data))
        .catch((err) => {
        console.log(err.message);
        });
    }, []);
  return (
    <>
    {/* {adventure && adventure.questions.map((question,index)=> (
        <Question key={index} question={question} />
    ))}     */}
    {adventure && adventure.questions[0] && <Question key={0} question={adventure.questions[0]} />}
    </>
  )
}

export default TakeAdventure