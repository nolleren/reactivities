import React from 'react';
import { Item, Button, Label, Segment } from 'semantic-ui-react';
import { IActivity } from '../../../app/models/activity';

interface IProps {
  activities: IActivity[];
  selectActivity: (id: string) => void;
  handleDeleteActivity: (id: string) => void;
}

export const ActivityList: React.FC<IProps> = ({
  activities,
  selectActivity,
  handleDeleteActivity,
}) => {
  return (
    <Segment clearing>
      <Item.Group divided>
        {activities.map(activity => (
          <Item key={activity.id}>
            <Item.Content>
              <Item.Header as="a">{activity.title}</Item.Header>
              <Item.Meta>{activity.date}</Item.Meta>
              <Item.Description>
                <div>{activity.description}</div>
                <div>
                  {activity.city}, {activity.venue}
                </div>
              </Item.Description>
              <Item.Extra>
                <Button
                  onClick={() => {
                    selectActivity(activity.id);
                  }}
                  floated="right"
                  content="view"
                  color="blue"
                />
                <Button
                  onClick={() => {
                    handleDeleteActivity(activity.id);
                  }}
                  floated="right"
                  content="delete"
                  color="red"
                />
                <Label basic content={activity.category} />
              </Item.Extra>
            </Item.Content>
          </Item>
        ))}
      </Item.Group>
    </Segment>
  );
};