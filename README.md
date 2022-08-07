
## DashPanels

- DashPanels have minimum and maximum x,y values
- DashPanels have a default x,y value
- DashPanel overrides PanelView UsePanelFrame to always return true
- Board is made up of DashPanels on an x,y grid
- Panel maximum x,y values are set by what layout is active
- Board holds the layout state, when layout state changes, panel min/max values are updated

## Layouts

- Layouts can be narrow, medium and wide
