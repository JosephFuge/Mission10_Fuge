import { Bowler } from '../types/Bowler';

export function BowlerCard(bowlerInfo: Bowler) {
  return (
    <div className="bowlercard">
      <h3>
        Name: {bowlerInfo.bowlerFirstName} {bowlerInfo.bowlerMiddleInit}{' '}
        {bowlerInfo.bowlerLastName}
      </h3>
      <p>Team: {bowlerInfo.team.teamName}</p>
    </div>
  );
}
