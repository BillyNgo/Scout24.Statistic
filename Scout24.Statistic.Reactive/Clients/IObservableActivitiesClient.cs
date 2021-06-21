namespace Scout24.Statistic.Reactive
{
    public interface IObservableActivitiesClient
    {
        IObservableEventsClient Events { get; }
        IObservableWatchedClient Watching { get; }
        IObservableStarredClient Starring { get; }
        IObservableFeedsClient Feeds { get; }
        IObservableNotificationsClient Notifications { get; }
    }
}