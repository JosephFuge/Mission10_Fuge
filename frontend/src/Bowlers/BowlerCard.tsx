import { Bowler } from '../types/Bowler';
import '../css/bowlers.css';

export function BowlerCard(bowlerInfo: Bowler) {
  return (
    <div className="bowlercard">
      <h3>
        Name: {bowlerInfo.bowlerFirstName} {bowlerInfo.bowlerMiddleInit}{' '}
        {bowlerInfo.bowlerLastName}
      </h3>
      <p>Team: {bowlerInfo.team.teamName}</p>
      <p>Address: {bowlerInfo.bowlerAddress}</p>
      <p>City: {bowlerInfo.bowlerCity}</p>
      <p>State: {bowlerInfo.bowlerState}</p>
      <p>ZIP: {bowlerInfo.bowlerZip}</p>
      <p>Phone Number: {bowlerInfo.bowlerPhoneNumber}</p>
    </div>
  );
}
