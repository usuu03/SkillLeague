import { useEffect, useState } from "react";
import { Challenge } from "./lib/types";
import "./index.css";

function App() {
  const [challenges, setChallenges] = useState<Challenge[]>([]);

  useEffect(() => {
    fetch("https://localhost:5001/api/challenges")
      .then((response) => response.json())
      .then((data) => setChallenges(data));
  }, []);
  return (
    <div>
      <h3 className="app" style={{ color: "red" }}>
        SkillLeague
      </h3>
      <ul className="list-none">
        {challenges.map((challenge) => (
          <li className="list-none" key={challenge.id}>
            {challenge.title}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
